﻿using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using DevExpress.ExpressApp.WebApi.Services;
using Microsoft.AspNetCore.OData;
using DevExpress.ExpressApp.Core;
using Demo.WebApi.JWT;
using DevExpress.ExpressApp.Security.Authentication;
using DevExpress.ExpressApp.Security.Authentication.ClientServer;
using Demo.WebApi.Core;
using DevExpress.ExpressApp.AspNetCore.WebApi;

namespace Demo.WebApi;

public class Startup {
    public Startup(IConfiguration configuration) {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services) {
        services
            .AddSingleton<IXpoDataStoreProvider>((serviceProvider) => {
                string connectionString = null;
                if(Configuration.GetConnectionString("ConnectionString") != null) {
                    connectionString = Configuration.GetConnectionString("ConnectionString");
                }
#if EASYTEST
                if(Configuration.GetConnectionString("EasyTestConnectionString") != null) {
                    connectionString = Configuration.GetConnectionString("EasyTestConnectionString");
                }
#endif
                return XPObjectSpaceProvider.GetDataStoreProvider(connectionString, null, true);
            })
            .AddScoped<IAuthenticationTokenProvider, JwtTokenProviderService>()
            .AddScoped<IObjectSpaceProviderFactory, ObjectSpaceProviderFactory>()
            .AddSingleton<IWebApiApplicationSetup, WebApiApplicationSetup>();

        services.AddXafAspNetCoreSecurity(Configuration, options => {
            options.RoleType = typeof(PermissionPolicyRole);
            // ApplicationUser descends from PermissionPolicyUser and supports the OAuth authentication. For more information, refer to the following topic: https://docs.devexpress.com/eXpressAppFramework/402197
            // If your application uses PermissionPolicyUser or a custom user type, set the UserType property as follows:
            options.UserType = typeof(Demo.Module.BusinessObjects.ApplicationUser);
            // ApplicationUserLoginInfo is only necessary for applications that use the ApplicationUser user type.
            // If you use PermissionPolicyUser or a custom user type, comment out the following line:
            options.UserLoginInfoType = typeof(Demo.Module.BusinessObjects.ApplicationUserLoginInfo);
            options.Events.OnSecurityStrategyCreated = securityStrategy => ((SecurityStrategy)securityStrategy).RegisterXPOAdapterProviders();
            options.SupportNavigationPermissionsForTypes = false;
        }).AddAuthenticationStandard(options => {
            options.IsSupportChangePassword = true;
        });
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => {
                options.TokenValidationParameters = new TokenValidationParameters() {
                    ValidateIssuerSigningKey = true,
                    //ValidIssuer = Configuration["Authentication:Jwt:Issuer"],
                    //ValidAudience = Configuration["Authentication:Jwt:Audience"],
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:Jwt:IssuerSigningKey"]))
                };
            });

        services.AddAuthorization(options => {
            options.DefaultPolicy = new AuthorizationPolicyBuilder(
                JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .RequireXafAuthentication()
                    .Build();
        });

        services
            .AddXafWebApi(Configuration, options => {
                // Use options.BusinessObject<YourBusinessObject>() to make the Business Object available in the Web API and generate the GET, POST, PUT, and DELETE HTTP methods for it.
            })
            .AddXpoServices();
        services
            .AddControllers()
            .AddOData((options, serviceProvider) => {
                options
                    .AddRouteComponents("api/odata", new EdmModelBuilder(serviceProvider).GetEdmModel())
                    .EnableQueryFeatures(100);
            });

        services.AddSwaggerGen(c => {
            c.EnableAnnotations();
            c.SwaggerDoc("v1", new OpenApiInfo {
                Title = "Demo API",
                Version = "v1",
                Description = @"Use AddXafWebApi(options) in the Demo.WebApi\Startup.cs file to make Business Objects available in the Web API."
            });
            c.AddSecurityDefinition("JWT", new OpenApiSecurityScheme() {
                Type = SecuritySchemeType.Http,
                Name = "Bearer",
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme() {
                            Reference = new OpenApiReference() {
                                Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                                Id = "JWT"
                            }
                        },
                        new string[0]
                    },
            });
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if(env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo WebApi v1");
            });
        }
        else {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. To change this for production scenarios, see: https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseRequestLocalization();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
        });
    }
}
