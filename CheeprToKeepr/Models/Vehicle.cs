using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.Expenses = new HashSet<Expense>();
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int VehicleID { get; set; }
        [Required]
        [RegularExpression(@"^[12]\d\d\d$")]
        public int Year { get; set; }
        [Required]
        [Display(Name = "Make")]
        [StringLength(250)]
        public string MakeName { get; set; }
        [Required]
        [Display(Name = "Model")]
        [StringLength(50)]
        public string ModelName1 { get; set; }
        [Display(Name = "Trim Level, optional (EX: GT, SXT, EX)")]
        public string ModelName2 { get; set; }
        [Required]
        [Display(Name = "Miles on vehicle")]
        [RegularExpression(@"[0-9]{0,}", ErrorMessage = "invalid number")]
        public int VehicleMileage { get; set; }
        [Display(Name ="Miles on Tires")]
        public int TireMileage { get; set; }
        [Display(Name = "Avg. Miles Per Gallon")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MilesPerGallon { get; set; }
        [Display(Name ="Make and Model")]
        public string ModelFullName
        {
            get
            {
                return ModelName1 + " " + ModelName2;
            }
        }
        [DisplayName("Owner")]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public ICollection<Fillup> Fillups { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
