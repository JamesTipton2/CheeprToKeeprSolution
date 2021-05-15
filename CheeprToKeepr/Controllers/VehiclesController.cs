using CheeprToKeepr.Data;
using CheeprToKeepr.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public VehiclesController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<Vehicle> vehicleList = _ctx.Vehicles;
            return View(vehicleList);
        }

        //GET-Creat
        public IActionResult Create()
        {
            
            return View();
        }

        //POST-Creat
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Vehicle vehicle)
        {
            _ctx.Vehicles.Add(vehicle);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
