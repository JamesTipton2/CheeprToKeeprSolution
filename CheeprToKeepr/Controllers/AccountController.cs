using CheeprToKeepr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Controllers
{
    public class AccountController : Controller
    {
        private readonly CheeprToKeeprContext _db;
        public AccountController(CheeprToKeeprContext db) => _db = db;

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
