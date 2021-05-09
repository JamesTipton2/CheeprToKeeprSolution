using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models.ViewModels
{
    public class ServicesViewModel
    {
        public int ServicesID { get; set; }
        public int VehicleID { get; set; }
        public int ServicesCategoryID { get; set; }
        public string ServiceName { get; set; }
        public DateTime ServiceDateTime { get; set; }
        public int VehicleMilesAtService { get; set; }
        public int VendorsID { get; set; }
    }
}
