using Demo.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Module.Controllers
{
    public class LopHPController:ViewController
    {
        public LopHPController()
        {
            TargetObjectType = typeof(LopHP);

            SimpleAction printAction = new (this, "In bảng điểm", "View")
            {
                ImageName = "Action_Printing_Print",
                TargetObjectType = typeof(LopHP),
                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
                //                ConfirmationMessage = "Chắc chắn in phiếu thu này?"
            };
            printAction.Execute += delegate (object sender, SimpleActionExecuteEventArgs e)
            {
                IObjectSpace objectSpace = ReportDataProvider.ReportObjectSpaceProvider.CreateObjectSpace(typeof(ReportDataV2));
                IReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(
                    new BinaryOperator("DisplayName", "diemhp"));
                if (reportData == null)
                {
                    throw new UserFriendlyException("Cannot find the 'diemhp' report.");
                }
                else
                {

                    ReportDataSourceHelper helper = Application.Modules.FindModule<ReportsModuleV2>().ReportsDataSourceHelper;
                    if (helper != null)
                    {
                        if (View.CurrentObject != null)
                        {
                            if (View.ObjectSpace.GetObject(View.CurrentObject) is LopHP p)
                            {
                                helper.BeforeShowPreview += (s, args) =>
                                {
                                    args.Report.Parameters["RecordOid"].Value = p.Oid;
                                };
                            }
                        };
                    }
                    string handle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);
                    ReportServiceController controller = Frame.GetController<ReportServiceController>();
                    if (controller != null)
                    {
                        controller.ShowPreview(handle);
                    }
                }
            };

        }

    }
}
