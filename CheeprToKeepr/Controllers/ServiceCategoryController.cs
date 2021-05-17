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
    public class ServiceCategoryController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public ServiceCategoryController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<ServiceCategory> list = _ctx.ServiceCategories;
            return View(list);
        }

        //GET-Creat
        public IActionResult Create()
        {

            return View();
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ServiceCategory item)
        {
            if (ModelState.IsValid)
            {
                _ctx.ServiceCategories.Add(item);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var item = _ctx.ServiceCategories.Find(id);
            if (id != null || id == 0)
            {
                item = _ctx.ServiceCategories.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(item);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? itemID)
        {
            var item = _ctx.ServiceCategories.Find(itemID);
            if (item == null)
            {
                return NotFound();
            }
            _ctx.ServiceCategories.Remove(item);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            var item = _ctx.ServiceCategories.Find(id);
            if (id != null || id == 0)
            {
                item = _ctx.ServiceCategories.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(item);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                _ctx.ServiceCategories.Update(serviceCategory);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(serviceCategory);
        }

        private bool ExpenseCategoryExists(int id)
        {
            return _ctx.ServiceCategories.Any(e => e.ServiceCategoryID == id);
        }
    }
}
