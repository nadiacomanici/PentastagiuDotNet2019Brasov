using MvcPentaStagiu.Models;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPentaStagiu.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var list = _userService.GetAll();
            var vmList = list.Select(x => new UserViewModel()
            {
                Id = x.Id,
                Age = x.Age,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();

            //See class extensions
            return View(vmList);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = _userService.Get(id).ToViewModel();
            return View(user);
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = _userService.Get(id).ToViewModel();
            return View(user);
        }

        [HttpPut]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var user = _userService.Get(id).ToViewModel();

            return View(user);
        }

        [HttpDelete]
        public ActionResult Delete(UserViewModel userViewModel)
        {
            return RedirectToAction("Index");
        }
    }
}