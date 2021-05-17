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
    public class ExpensesController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        public ExpensesController(CheeprToKeeprContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> expenseList = _ctx.Expenses;

            foreach(var obj in expenseList)
            {
                obj.ExpenseCategory = _ctx.ExpenseCategories
                    .FirstOrDefault(c => 
                    c.ExpenseCategoryID == obj.ExpenseCategoryID);
            }

            return View(expenseList);
        }

        //GET-Creat
        public IActionResult Create()
        {

            ExpensesViewModel expenseVM = new ExpensesViewModel()
            {
                Expense = new Expense(),
                CategoryList = _ctx.ExpenseCategories.Select(c => new SelectListItem
                {
                    Text = c.ExpenseType,
                    Value = c.ExpenseCategoryID.ToString()
                }),
                VehicleList = _ctx.Vehicles.Select(v => new SelectListItem
                {
                    Text = v.ModelFullName,
                    Value = v.VehicleID.ToString()
                })
            };

            return View(expenseVM);
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ExpensesViewModel item)
        {
            if (ModelState.IsValid)
            {
                _ctx.Expenses.Add(item.Expense);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var expense = _ctx.Expenses.Find(id);
            if (id != null || id == 0)
            {
                expense = _ctx.Expenses.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(expense);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? expenseID)
        {
            var expense = _ctx.Expenses.Find(expenseID);
            if (expense == null)
            {
                return NotFound();
            }
            _ctx.Expenses.Remove(expense);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            ExpensesViewModel expenseVM = new ExpensesViewModel()
            {
                Expense = new Expense(),
                CategoryList = _ctx.ExpenseCategories.Select(c => new SelectListItem
                {
                    Text = c.ExpenseType,
                    Value = c.ExpenseCategoryID.ToString()
                }),
                VehicleList = _ctx.Vehicles.Select(v => new SelectListItem
                {
                    Text = v.ModelFullName,
                    Value = v.VehicleID.ToString()
                })
            };

            //if (id != null || id == 0)
            //{
            //    return NotFound();
            //}
            //expenseVM.Expense = _ctx.Expenses.Find(id);
            //if (expenseVM.Expense == null)
            //{
            //    return NotFound();
            //}
            //return View(expenseVM);

            expenseVM.Expense = _ctx.Expenses.Find(id);
            if (id != null || id == 0)
            {
                expenseVM.Expense = _ctx.Expenses.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(expenseVM);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _ctx.Expenses.Update(expense);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(expense);
        }

        ////POST Vehicles/Edit 
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UpdatePost(int? vehicleID)
        //{
        //    //var vehicle = _ctx.Vehicles.Find(vehicleID);
        //    if (vehicleID == null || vehicleID == 0)
        //    {
        //        return NotFound();
        //        //vehicle = _ctx.Vehicles.Find(vehicleID);
        //    }
        //    var vehicleToUpdate = await _ctx.Vehicles.FirstOrDefaultAsync(v => v.VehicleID == vehicleID);
        //    if(await TryUpdateModelAsync<Vehicle>(
        //        vehicleToUpdate,
        //        "",
        //        v => v.UserID, v => v.Year, v => v.MakeName, v => v.ModelName1,
        //        v => v.ModelName2, v => v.VehicleMileage, v => v.TireMileage, v => v.MilesPerGallon))
        //    {
        //        try
        //        {
        //            await _ctx.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch(DbUpdateException /* ex */)
        //        {
        //            ModelState.AddModelError("","Unable to save changes. " +
        //                "Try again, and if the problem persists, " +
        //                "see your system administrator.");
        //        }
        //    }
        //    return View(vehicleToUpdate);
        //}

        private bool ExpenseExists(int id)
        {
            return _ctx.Expenses.Any(e => e.ExpenseID == id);
        }
    }
}
