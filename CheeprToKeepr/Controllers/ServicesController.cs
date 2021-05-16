using CheeprToKeepr.Data;
using CheeprToKeepr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public ServicesController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<Service> servicesList = _ctx.Services;
            return View(servicesList);
        }

        //GET-Create
        public IActionResult Create()
        {

            return View();
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("Name,ServiceDateTime,VehicleMilesAtService")] Service service)
        {
            if (ModelState.IsValid)
            {
                _ctx.Services.Add(service);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(service);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var service = _ctx.Services.Find(id);
            if (id != null || id == 0)
            {
                service = _ctx.Services.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(service);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? servicesID)
        {
            var service = _ctx.Services.Find(servicesID);
            if (service == null)
            {
                return NotFound();
            }
            _ctx.Services.Remove(service);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            var service = _ctx.Services.Find(id);
            if (id != null || id == 0)
            {
                service = _ctx.Services.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(service);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(Service service)
        {
            if (ModelState.IsValid)
            {
                _ctx.Services.Update(service);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(service);
        }

        private bool ServiceExists(int id)
        {
            return _ctx.Services.Any(s => s.ServiceID == id);
        }
    }
}
