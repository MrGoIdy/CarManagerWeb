﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CarManagerWeb.Models.DataBase
{
    public class MySqlExecuter
    {      
        public static MySqlDataSetResult SelectData(string sql, string connection)
        {
            MySqlDataSetResult sqlResult = new MySqlDataSetResult();
            try
            {
                MySqlConnection sqlConnection = OpenConnection(connection);
               
                try
                {
                    MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = sqlCommand;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    sqlResult.ResultData = dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    sqlResult.HasError = true;
                    sqlResult.ErrorText = ex.Message;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlResult.ErrorText = ex.Message;
                sqlResult.HasError = true;
            }
            return sqlResult;

        }

        public static MySqlConnection OpenConnection(string connection)
        {
            MySqlConnection sqlConnection = new MySqlConnection(connection);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
