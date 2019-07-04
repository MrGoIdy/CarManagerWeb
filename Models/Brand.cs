using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManagerWeb.Models
{
    public class Brand
    {
        public readonly int Id;
        private string name;

        public Brand(int id)
        {
            Id = id;
        }

        public Brand(int id, string brand)
        {
            Id = id;
            Name = brand;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    name = value;
                }
            }
            get { return name; }
        }
    }
}