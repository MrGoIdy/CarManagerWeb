using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CarManagerWeb.Models.DataBase
{
    public class MySqlDataSetResult
    {
        public DataTable ResultData;
        public string ErrorText;
        public bool HasError;
    }
}