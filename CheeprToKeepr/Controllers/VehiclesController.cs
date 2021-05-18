using CheeprToKeepr.Data;
using CheeprToKeepr.Infrastructure;
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
    public class VehiclesController : Controller
    {
        private readonly CheeprToKeeprContext _ctx;
        private readonly ICheeprToKeeprService _service;
        public VehiclesController(CheeprToKeeprContext ctx, ICheeprToKeeprService service)
        {
            _service = service;
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            _service.GetOwnerList();
            IEnumerable<Vehicle> vehicleList = _ctx.Vehicles;
            return View(vehicleList);
        }

        //GET-Creat
        public IActionResult Create()
        {
            VehicleViewModel vehicleVM = new VehicleViewModel()
            {
                Vehicle = new Vehicle(),
                UserList = _ctx.Users.Select(u => new SelectListItem
                {
                    Text = u.FirstName + " " + u.LastName,
                    Value = u.UserID.ToString()
                })
            };


            return View(vehicleVM);
        }

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(VehicleViewModel item)
        {
            if (ModelState.IsValid)
            {
                _ctx.Vehicles.Add(item.Vehicle);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET Delete
        public IActionResult Delete(int? id)
        {
            var vehicle = _ctx.Vehicles.Find(id);
            if (id != null || id == 0)
            {
                vehicle = _ctx.Vehicles.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(vehicle);
        }
        //POST-Delete
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? vehicleID)
        {
            var vehicle = _ctx.Vehicles.Find(vehicleID);
            if (vehicle == null)
            {
                return NotFound();
            }
            _ctx.Vehicles.Remove(vehicle);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Delete
        public IActionResult Update(int? id)
        {
            var vehicle = _ctx.Vehicles.Find(id);
            if (id != null || id == 0)
            {
                vehicle = _ctx.Vehicles.Find(id);
            }
            else
            {
                return NotFound();
            }
            return View(vehicle);
        }

        //POST Update
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _ctx.Vehicles.Update(vehicle);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(vehicle);
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

        private bool VehicleExists(int id)
        {
            return _ctx.Vehicles.Any(e => e.VehicleID == id);
        }
    }
}
