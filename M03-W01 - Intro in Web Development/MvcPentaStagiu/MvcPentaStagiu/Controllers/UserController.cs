using MvcPentaStagiu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPentaStagiu.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("Details");
        }

        [HttpGet]
        public ActionResult Details()
        {
            UserViewModel userViewModel = new UserViewModel()
            {
                FirstName = "Mircea",
                LastName = "Blendea",
                Email = "something@something.com",
                Age = 27
            };

            return View(userViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Description = "Pagina de creat User";
            ViewBag.User = new UserViewModel()
            {
                FirstName = "TestName",
                LastName = "TestName"
            };

            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}