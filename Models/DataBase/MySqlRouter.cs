using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManagerWeb.Models.DataBase
{
    public class MySqlRouter
    {
        const string SERVER = "5.132.159.203";
        const string USER_ID = "alex";
        const string PASSWORD = "NastiViennaMinsk2018_";
        const string DATABASE = "Test_Alex";

        public static string GetConnectionString()
        {
            try
            {
                return (new MySqlConnectionStringBuilder
                {
                    Server = SERVER,
                    UserID = USER_ID,
                    Password = PASSWORD,
                    Database = DATABASE
                })
                .ConnectionString;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }
    }
}