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
        public int ExpenseCategoryID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public System.DateTime ExpenseDateTime { get; set; }
        public int VehicleID { get; set; }
        public int Cost { get; set; }

        public virtual ExpenseCategory ExpenseCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
