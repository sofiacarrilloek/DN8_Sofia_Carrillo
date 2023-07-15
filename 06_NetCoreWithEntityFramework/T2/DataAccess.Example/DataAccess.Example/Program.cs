using DataAccess.Example.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.Example
{
    class Program
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=sqltesting;user=root;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=True;password='Admin1234'";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GetUsers();
            var allUsers = GetUsers();
            var contosodUser = GetUserById(2);
            var teslaUser = GetUserById(3);

            var companyResult = CreateCompany("DELL", "MX", "admin@dell.com", "user@hp.com");
        }



        private static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {

                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetAllUsers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    /////////

                    User user = new User
                    {
                        Id = (int)reader["iduser"],
                        UserName = reader["username"] as string,
                        Email = reader["email"] as string,
                        CompanyId = (int)reader["idcompany"]
                    };

                    users.Add(user);

                    ///////////

                }
            }
            finally
            {
                connection.Close();
            }

            return null;
        }



        private static User GetUserById(int userId)
        {
            User user = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetUserById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_id", userId);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    /////////

                    user = new User
                    {
                        Id = (int)reader["iduser"],
                        UserName = reader["username"] as string,
                        Email = reader["email"] as string,
                        CompanyId = (int)reader["idcompany"]
                    };



                    ///////////

                }

            }
            finally
            {
                connection.Close();
            }
            return user;

        }


        private static CompanyCreationResource CreateCompany(string companyName, string companyLocation,
           string adminEmail, string employeeEmail)
        {
            CompanyCreationResource result = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("CreateCompany", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_companyName", companyName);
                command.Parameters.AddWithValue("_location", companyLocation);
                command.Parameters.AddWithValue("_adminEmail", adminEmail);
                command.Parameters.AddWithValue("_userEmail", employeeEmail);

                var companyIdParameter = command.Parameters.Add("_idcompany", System.Data.DbType.Int32);
                companyIdParameter.Direction = System.Data.ParameterDirection.Output;

                var adminIdParameter = command.Parameters.Add("_idadmin", System.Data.DbType.Int32);
                adminIdParameter.Direction = System.Data.ParameterDirection.Output;

                var userIdParameter = command.Parameters.Add("_iduser", System.Data.DbType.Int32);
                userIdParameter.Direction = System.Data.ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = new CompanyCreationResource
                {
                    CompanyId = (int)companyIdParameter.Value,
                    AdminId = (int)adminIdParameter.Value,
                    UserId = (int)userIdParameter.Value
                };

            }
            finally
            {
                connection.Close();
            }
            return result;

        }



    }

}
