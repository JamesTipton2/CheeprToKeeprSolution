using CheeprToKeepr.Models;
using CheeprToKeepr.Models.ViewModels;
using CheeprToKeepr.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Controllers
{
    public class HomeController : Controller
    {
        private readonly CheeprToKeeprContext _context;

        public HomeController(CheeprToKeeprContext context) => _context = context;

        //public async Task<ActionResult> About()
        //{
        //    //IQueryable<VehicleGroup> data =
        //    //    from vehicle in _context.Vehicles
        //    //    group vehicle by vehicle.UserID into vehicleGroup
        //    //    select new VehiclesGroup()
        //    //    {
        //    //        MakeandModel = vehicleGroup.Key,
        //    //        MPG = vehicleGroup
        //    //    };
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
