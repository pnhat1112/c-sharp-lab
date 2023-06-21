using AutomobileLibary.BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibary.DataAcess
{
    public class CarDBContext:BaseDAL
    {
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext(){ }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleasedYear from Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleasedYear = dataReader.GetInt32(4)
                    });

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return cars;
        }
        
        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleasedYear" + " from Cars where CarID = @CarID";
            try
            {
                var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleasedYear = dataReader.GetInt32(4)
                    };

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }

        public void AddNew(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarID);
                if(pro == null)
                {
                    string SQLInsert = "Insert Cars values(@CarID, @CarName, @Manufacturer, @Price, @ReleasedYear)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleasedYear", 4, car.ReleasedYear, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                } else
                {
                    throw new Exception("The Car is already exist");
                }
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarID);
                if (pro != null)
                {
                    string SQLUpdate = "Update Cars set CarName = @CarName, Manufuturer = @Manufuturer," 
                        + "Price = @Price, ReleasedYear = @ReleasedYear where CarID=@CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleasedYear", 4, car.ReleasedYear, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Car does not already exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int carID)
        {
            try
            {
                Car pro = GetCarByID(carID);
                if (pro != null)
                {
                    string SQLDelete = "Delete Cars where CarID = @CarID";
                    var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Car does not already exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
