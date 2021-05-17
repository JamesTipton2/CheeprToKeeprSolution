using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Models.ViewModels
{
    public class VehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<SelectListItem> UserList { get; set; }

    }
}
