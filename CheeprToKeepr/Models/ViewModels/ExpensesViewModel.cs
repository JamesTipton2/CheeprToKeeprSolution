using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models.ViewModels
{
    public class ExpensesViewModel
    {
        public Expense Expense { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> VehicleList { get; set; }
    }
}
