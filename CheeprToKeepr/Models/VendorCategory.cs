using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class VendorCategory
    {
        public VendorCategory()
        {
            this.Vendors = new HashSet<Vendor>();
        }
        [Key]
        public int VendorCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Vendery Type")]
        public string VendorType { get; set; }

        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}

