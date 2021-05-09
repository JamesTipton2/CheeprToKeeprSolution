using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class Service
    {
        [Key]
        public int ServicesID { get; set; }
        public int VehicleID { get; set; }
        public int ServicesCategoryID { get; set; }
        public string ServiceName { get; set; }
        public System.DateTime ServiceDateTime { get; set; }
        public Nullable<int> VehicleMilesAtService { get; set; }
        public int VendorID { get; set; }

        public virtual ServicesCategory ServicesCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
