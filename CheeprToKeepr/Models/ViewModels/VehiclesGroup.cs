using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeprToKeepr.Models;

namespace CheeprToKeepr.Models.ViewModels
{
    public class VehiclesGroup
    {
        public string MakeandModel
        {
            get
            {
                foreach (Vehicle Vehicle in Vehicles)
                {
                    string make = Vehicle.MakeName;
                    string model = Vehicle.ModelName1;
                    string result = $"{make} {model}";
                }
                return result;
            }
        }
        public decimal MPG { get; set; }
    }
}
