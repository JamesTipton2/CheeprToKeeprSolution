using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models.ViewModels
{
    public class ExpensesViewModel
    {
        public int ExpenseID { get; set; }
        public int ExpenseCategoryID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime ExpenseDateTime { get; set; }
        public int VehicleID { get; set; }
        public int Cost { get; set; }
    }
}
