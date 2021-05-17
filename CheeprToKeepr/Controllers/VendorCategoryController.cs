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
    public class VendorCategoryController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public VendorCategoryController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<VendorCategory> vendorCategoryeList = _ctx.VendorCategories;
            return View(vendorCategoryeList);
        }

        //GET-Creat
        public IActionResult Create()
        {

            return View();
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(VendorCategory vendorCategory)
        {
            if (ModelState.IsValid)
            {
                _ctx.VendorCategories.Add(vendorCategory);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(vendorCategory);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var expenseCategory = _ctx.VendorCategories.Find(id);
            if (id != null || id == 0)
            {
                expenseCategory = _ctx.VendorCategories.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(expenseCategory);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? expenseCategoryID)
        {
            var expenseCategory = _ctx.VendorCategories.Find(expenseCategoryID);
            if (expenseCategory == null)
            {
                return NotFound();
            }
            _ctx.VendorCategories.Remove(expenseCategory);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            var expenseCategory = _ctx.VendorCategories.Find(id);
            if (id != null || id == 0)
            {
                expenseCategory = _ctx.VendorCategories.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(expenseCategory);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(VendorCategory vendorCategory)
        {
            if (ModelState.IsValid)
            {
                _ctx.VendorCategories.Update(vendorCategory);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(vendorCategory);
        }

        private bool ExpenseCategoryExists(int id)
        {
            return _ctx.VendorCategories.Any(e => e.VendorCategoryID == id);
        }
    }
}
