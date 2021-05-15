using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class User
    {
        public User()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }
        [Key]
        public int UserID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid First Name")]

        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address Line 1")]
        [Required]
        [RegularExpression(@"[-_,A-Za-z0-9]{1,250}$", ErrorMessage="Please Enter a valid Address")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Line 2, optional(Apt, Room, Suite, etc.)")]
        public string AddressLine2 { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [Display(Name = "Zip Code(5 digit)")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Invalid Zip Code")]
        public string PostalCode { get; set; }
        [Required]
        [Display(Name = "State, abbrevaited(EX: NY)")]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [DataType("Email")]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "invalid email")]
        public string Email { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
