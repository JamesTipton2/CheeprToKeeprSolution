﻿using System;
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
        //public int VehicleID { get; set; }
        //public int ServicesCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:s}", ApplyFormatInEditMode = true)]
        public System.DateTime ServiceDateTime { get; set; }
        [RegularExpression(@"[0-9]{0,}", ErrorMessage = "invalid number")]
        public int? VehicleMilesAtService { get; set; }
        //public int VendorID { get; set; }

        public virtual ServicesCategory ServicesCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
