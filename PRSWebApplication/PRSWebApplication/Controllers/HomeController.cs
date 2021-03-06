﻿using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PRSWebApplication.Models;
using Microsoft.AspNetCore.Http;

namespace PRSWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // Added
        private PRSWebLibrary.PRSContext _context;
        public HomeController(PRSWebLibrary.PRSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        // Ended

        // Purchase Reuqest
        //public IActionResult PurchaseRequests()
        //{
            //return View();
        //}

        // Ended

        // Vendor
        public IActionResult Vendors()
        {
            return View(_context.Vendors.ToList());
        }

        // Ended

        // Product
        public IActionResult Products()
        {
            return View(_context.Products.ToList());
        }

        // Ended

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Information";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Added
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(PRSWebLibrary.Models.User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + " is succesffully registered.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(PRSWebLibrary.Models.User user)
        {
            var account = _context.Users
            .FirstOrDefault(u => u.UserName == user.UserName
            && u.Password == user.Password);

            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.Id.ToString());
                HttpContext.Session.SetString("Username", account.UserName);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is wrong.");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
