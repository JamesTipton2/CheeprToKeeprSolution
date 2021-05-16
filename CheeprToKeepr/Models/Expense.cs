using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //public int VehicleID { get; set; }
        //public int ExpenseCategoryID { get; set; }

        public virtual ExpenseCategory ExpenseCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
