using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models

{
    public class ServicesCategory
    {
        public ServicesCategory()
        {
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int ServicesCategoryID { get; set; }
        public string ServiceType { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
