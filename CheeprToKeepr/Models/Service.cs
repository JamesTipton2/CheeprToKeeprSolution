using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:s}", ApplyFormatInEditMode = true)]
        public System.DateTime ServiceDateTime { get; set; }
        [RegularExpression(@"[0-9]{0,}", ErrorMessage = "invalid number")]
        public int? VehicleMilesAtService { get; set; }
        [DisplayName("Service Type")]
        public int ServiceCategoryID { get; set; }
        [ForeignKey("ServiceCategoryID")]
        public virtual ServiceCategory ServicesCategory { get; set; }
        [DisplayName("Vehicle")]
        public int VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public virtual Vehicle Vehicle { get; set; }
        [DisplayName("Vendor")]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        public virtual Vendor Vendor { get; set; }
    }
}
