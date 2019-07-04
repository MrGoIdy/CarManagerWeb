using CarManagerWeb.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CarManagerWeb.Models
{
    public class CarManager
    {
        public static List<Brand> GetAllBrands()
        {
            List<Brand> cars = new List<Brand>();
            var carBrandsSqlResult = MySqlExecuter.SelectData("SELECT Id, Name FROM car_brands", DataBaseController.GetConnectionString());
            if (carBrandsSqlResult.HasError)
            {
                throw new Exception(carBrandsSqlResult.ErrorText);
            }
            else
            {
                foreach (DataRow row in carBrandsSqlResult.ResultData.Rows)
                {
                    int id = Int32.Parse(row["Id"].ToString());
                    string brand = row["Name"].ToString();
                    cars.Add(new Brand(id, brand));
                }
                return cars;
            }
        }

        public static List<string> GetModels(int brandId)
        {
            List<string> models = new List<string>();
            var carBrandsSqlResult = MySqlExecuter.SelectData($"SELECT Name FROM car_models WHERE Brand_Id='{brandId}'", DataBaseController.GetConnectionString());
            if (carBrandsSqlResult.HasError)
            {
                throw new Exception(carBrandsSqlResult.ErrorText);
            }
            else
            {
                foreach (DataRow row in carBrandsSqlResult.ResultData.Rows)
                {
                    models.Add(row["Name"].ToString());
                }
                return models;
            }
        }
    }
}