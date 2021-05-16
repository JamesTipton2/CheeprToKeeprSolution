﻿using CheeprToKeepr.Data;
using CheeprToKeepr.Models;
using Microsoft.AspNetCore.Mvc;
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

        //POST-Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UserID,Year,MakeName,ModelName1,ModelName2,VehicleMileage,TireMileage,MilesPerGallon")]Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _ctx.Vehicles.Add(vehicle);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(vehicle);
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
