using CheeprToKeepr.Data;
using CheeprToKeepr.Models;
using CheeprToKeepr.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            foreach (var obj in servicesList)
            {
                obj.ServiceCategory = _ctx.ServiceCategories
                    .FirstOrDefault(s =>
                    s.ServiceCategoryID == obj.ServiceCategoryID);
            }

            return View(servicesList);
        }

        //GET-Create
        public IActionResult Create()
        {
            ServiceViewModel serviceVM = new ServiceViewModel()
            {
                Service = new Service(),
                CategoryList = _ctx.ServiceCategories.Select(c => new SelectListItem
                {
                    Text = c.ServiceType,
                    Value = c.ServiceCategoryID.ToString()
                }),
                VehicleList = _ctx.Vehicles.Select(v => new SelectListItem
                {
                    Text = v.ModelFullName,
                    Value = v.VehicleID.ToString()
                }),
                VendorList = _ctx.Vendors.Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VendorID.ToString()
                })
            };
            return View(serviceVM);
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ServiceViewModel item)
        {
            if (ModelState.IsValid)
            {
                _ctx.Services.Add(item.Service);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(item);
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
            ServiceViewModel serviceVM = new ServiceViewModel()
            {
                Service = new Service(),
                CategoryList = _ctx.ServiceCategories.Select(c => new SelectListItem
                {
                    Text = c.ServiceType,
                    Value = c.ServiceCategoryID.ToString()
                }),
                VehicleList = _ctx.Vehicles.Select(v => new SelectListItem
                {
                    Text = v.ModelFullName,
                    Value = v.VehicleID.ToString()
                }),
                VendorList = _ctx.Vendors.Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VendorID.ToString()
                })
            };
            serviceVM.Service = _ctx.Services.Find(id);
            if (id != null || id == 0)
            {
                serviceVM.Service = _ctx.Services.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(serviceVM);
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
