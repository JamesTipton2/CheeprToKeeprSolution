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
    public class VendorController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public VendorController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<Vendor> list = _ctx.Vendors;

            foreach (var obj in list)
            {
                obj.VendorCategory = _ctx.VendorCategories
                    .FirstOrDefault(c =>
                    c.VendorCategoryID == obj.VendorCategoryID);
            }

            return View(list);
        }

        //GET-Creat
        public IActionResult Create()
        {
            VendorViewModel vendorVM = new VendorViewModel()
            {
                Vendor = new Vendor(),
                CategoryList = _ctx.VendorCategories.Select(c => new SelectListItem
                {
                    Text = c.VendorType,
                    Value = c.VendorCategoryID.ToString()
                })
            };
            return View(vendorVM);
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(VendorViewModel item)
        {
            if (ModelState.IsValid)
            {
                _ctx.Vendors.Add(item.Vendor);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var vendor = _ctx.Vendors.Find(id);
            if (id != null || id == 0)
            {
                vendor = _ctx.Vendors.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(vendor);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? vendorID)
        {
            var vendor = _ctx.Vendors.Find(vendorID);
            if (vendor == null)
            {
                return NotFound();
            }
            _ctx.Vendors.Remove(vendor);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            VendorViewModel vendorVM = new VendorViewModel()
            {
                Vendor = new Vendor(),
                CategoryList = _ctx.VendorCategories.Select(c => new SelectListItem
                {
                    Text = c.VendorType,
                    Value = c.VendorCategoryID.ToString()
                })
            };
            vendorVM.Vendor = _ctx.Vendors.Find(id);
            if (id != null || id == 0)
            {
                vendorVM.Vendor = _ctx.Vendors.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(vendorVM);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _ctx.Vendors.Update(vendor);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(vendor);
        }

        private bool ExpenseCategoryExists(int id)
        {
            return _ctx.Vendors.Any(e => e.VendorID == id);
        }
    }
}
