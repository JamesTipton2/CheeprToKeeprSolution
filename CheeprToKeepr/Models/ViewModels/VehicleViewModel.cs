using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int VehicleID { get; set; }
        public int UserID { get; set; }
        public int Year { get; set; }
        public string MakeName { get; set; }
        public string ModelName1 { get; set; }
        public string ModelName2 { get; set; }
        public int VehicleMileage { get; set; }
        public int GasByGallons { get; set; }
        public int TireMileage { get; set; }
        public decimal MPG
        {
            get
            {
                return VehicleMileage / GasByGallons;
            }
        }
    }
}
