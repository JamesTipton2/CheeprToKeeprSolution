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
    public class ExpenseCategoryController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public ExpenseCategoryController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpenseCategory> expenseCategoryeList = _ctx.ExpenseCategories;
            return View(expenseCategoryeList);
        }

        //GET-Creat
        public IActionResult Create()
        {

            return View();
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseCategory expenseCategory)
        {
            if (ModelState.IsValid)
            {
                _ctx.ExpenseCategories.Add(expenseCategory);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(expenseCategory);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var expenseCategory = _ctx.ExpenseCategories.Find(id);
            if (id != null || id == 0)
            {
                expenseCategory = _ctx.ExpenseCategories.Find(id);
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
            var expenseCategory = _ctx.ExpenseCategories.Find(expenseCategoryID);
            if (expenseCategory == null)
            {
                return NotFound();
            }
            _ctx.ExpenseCategories.Remove(expenseCategory);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            var expenseCategory = _ctx.ExpenseCategories.Find(id);
            if (id != null || id == 0)
            {
                expenseCategory = _ctx.ExpenseCategories.Find(id);
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
        public IActionResult Update(ExpenseCategory expenseCategory)
        {
            if (ModelState.IsValid)
            {
                _ctx.ExpenseCategories.Update(expenseCategory);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(expenseCategory);
        }

        private bool ExpenseCategoryExists(int id)
        {
            return _ctx.ExpenseCategories.Any(e => e.ExpenseCategoryID == id);
        }
    }
}
