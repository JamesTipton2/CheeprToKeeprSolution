using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models
{
    public class ExpenseCategory
    {
        public ExpenseCategory()
        {
            this.Expenses = new HashSet<Expense>();
        }
        [Key]
        public int ExpenseCategoryID { get; set; }
        public string ExpenseType { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
