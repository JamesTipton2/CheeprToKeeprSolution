using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:s}", ApplyFormatInEditMode = true)]
        public System.DateTime ExpenseDateTime { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{0,}", ErrorMessage = "invalid number")]
        public int Cost { get; set; }
        [DisplayName("Vehicle")]
        public int VehicleID { get; set; }
        [DisplayName("Expense Type")]
        public int ExpenseCategoryID { get; set; }
        [ForeignKey("ExpenseCategoryID")]
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        [ForeignKey("VehicleID")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
