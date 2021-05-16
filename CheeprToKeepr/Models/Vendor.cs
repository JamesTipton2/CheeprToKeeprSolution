using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class Vendor
    {
        public Vendor()
        {
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int VendorID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [Display(Name = "State, abbrevaited(EX: NY)")]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [Display(Name = "Zip Code(5 digit)")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Invalid Zip Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$")]
        public string PhoneNumber { get; set; }
        [DataType("Email")]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "invalid email")]
        public string Email { get; set; }
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please provide a valid email address")]
        public string Website { get; set; }
        [DisplayName("Vendor Type")]
        public int VendorCategoryID { get; set; }

        public virtual ICollection<Service> Services { get; set; }
        [ForeignKey("VendorCategoryID")]
        public virtual VendorCategory VendorCategory { get; set; }
    }
}
