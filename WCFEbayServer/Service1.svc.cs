using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEbayServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public static List<Car> AllCars = new List<Car>();
        public static List<users> AllUsers = new List<users>();

        public List<Car> allCars()
        {
            lock (AllCars)
            {
                List<Car> AllCarsInside = new List<Car>();

                string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";
                using (MySqlConnection connection = new MySqlConnection(cs))
                {
                    string query = "select * from car;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        {
                            while (reader.Read())
                            {
                                Car normalCar = new Car();
                                normalCar.Type = reader["Type"].ToString();
                                normalCar.Brand = (reader["Brand"].ToString());
                                normalCar.License_plate = (reader["license_plate"].ToString());
                                normalCar.CarID = Convert.ToInt32(reader["carID"]);

                                AllCarsInside.Add(normalCar);
                            }
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return AllCarsInside;
                }

            }
        }
        public List<users> allUsers()
        {
            lock (AllUsers)
            {
                List<users> AllUsersInside = new List<users>();

                string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";
                using (MySqlConnection connection = new MySqlConnection(cs))
                {
                    string query = "select * from users;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        {
                            while (reader.Read())
                            {
                                users normalUser = new users();

                                normalUser.UserID = Convert.ToInt32(reader["UserID"]);
                                normalUser.FirstName = (reader["firstName"].ToString());
                                normalUser.SecondName = (reader["SecondName"].ToString());

                                AllUsersInside.Add(normalUser);
                            }
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return AllUsersInside;
                }

            }
        }

        #region to deal with DataBase

        public Car GetCars(int id)
        {
            Car normalCar = new Car();
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";//still
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                string query = "select * from car where carID=@param_ID;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@param_ID", MySqlDbType.Int32).Value = id;
                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        normalCar.Type = reader["Type"].ToString();
                        normalCar.Brand = (reader["Brand"].ToString());
                        normalCar.License_plate = (reader["license_plate"].ToString());
                        normalCar.CarID = Convert.ToInt32(reader["carID"]);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return normalCar;
        }
        public void SaveCars(Car normalCar)
        {
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";//still
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SaveCars", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter TypeParameter = new MySqlParameter //1
                {
                    ParameterName = "@param_Type",
                    Value = normalCar.Type
                };
                cmd.Parameters.Add(TypeParameter);

                MySqlParameter BrandParameter = new MySqlParameter //2
                {
                    ParameterName = "@param_Brand",
                    Value = normalCar.Brand
                };
                cmd.Parameters.Add(BrandParameter);

                MySqlParameter LicensePlateParameter = new MySqlParameter //3
                {
                    ParameterName = "@param_License_plate",
                    Value = normalCar.License_plate
                };
                cmd.Parameters.Add(LicensePlateParameter);

                MySqlParameter CaridParameter = new MySqlParameter //4
                {
                    ParameterName = "@param_CarID",
                    Value = normalCar.CarID
                };
                cmd.Parameters.Add(CaridParameter);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void DeleteCars(int id)
        {
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteCars", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@param_Id", MySqlDbType.Int32).Value = id;
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public users GetUsers(int id)
        {
            users normalUsers = new users();
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";//still
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                string query = "select * from users where UserID=@param_ID;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@param_ID", MySqlDbType.Int32).Value = id;
                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        normalUsers.UserID = Convert.ToInt32(reader["UserID"]);
                        normalUsers.SecondName = (reader["SecondName"].ToString());
                        normalUsers.FirstName = (reader["firstName"].ToString());
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return normalUsers;
        }
        public void SaveUsers(users normalUser)
        {
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";//still
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SaveUsers", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter FirstNameParameter = new MySqlParameter //1
                {
                    ParameterName = "@param_FirstName",
                    Value = normalUser.FirstName
                };
                cmd.Parameters.Add(FirstNameParameter);

                MySqlParameter SecondNameParameter = new MySqlParameter //2
                {
                    ParameterName = "@param_SecondName",
                    Value = normalUser.SecondName
                };
                cmd.Parameters.Add(SecondNameParameter);

                MySqlParameter UserIDParameter = new MySqlParameter //3
                {
                    ParameterName = "@param_UserID",
                    Value = normalUser.UserID
                };
                cmd.Parameters.Add(UserIDParameter);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void DeleteUsers(int id)
        {
            string cs = @"server=localhost;User Id=root;Password=Ahmed22;Database=cartype";
            using (MySqlConnection connection = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteUsers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@param_Id", MySqlDbType.Int32).Value = id;
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        #endregion

        public ServiceData TestConnection(string strConnectionString)
        {
            ServiceData myServiceData = new ServiceData();
            try
            {
                ServiceHost host = new ServiceHost(typeof(WCFEbayServer.Service1));
                host.Open();
                myServiceData.Result = true;
                host.Close();
                return myServiceData;
            }
            catch (SqlException sqlEx)
            {
                myServiceData.Result = false;
                myServiceData.ErrorMessage = " I cannot connect" + "later?";
                myServiceData.ErrorDetails = sqlEx.ToString();
                throw new FaultException<ServiceData>(myServiceData, sqlEx.ToString());
            }
            catch (Exception ex)
            {
                myServiceData.Result = false;
                myServiceData.ErrorMessage = "Unknown error";
                myServiceData.ErrorDetails = ex.ToString(); throw new
                   FaultException<ServiceData>(myServiceData, ex.ToString());
            }
        }
    }
}
