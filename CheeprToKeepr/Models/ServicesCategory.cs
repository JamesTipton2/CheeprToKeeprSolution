using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models

{
    public class ServiceCategory
    {
        public ServiceCategory()
        {
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int ServiceCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Service Type")]
        public string ServiceType { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
