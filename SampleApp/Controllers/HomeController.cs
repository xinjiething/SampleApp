using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using SampleApp.Controllers;
using SampleApp.Models;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {
       
        // Display Index page (view)
        public IActionResult Index()
        {
            return View();
        }

        // Retrieving information from form
        // Invoked upon submission of form
        [HttpPost]
        public IActionResult user(string name, string phone, string address)
        {
            // passing information from form to model
            UserInfoModel user = new UserInfoModel();
            user.name = name;
            user.phone = phone;
            user.address = address;
            user.createdAt = DateTime.Now;
            // pass model to GET method which render view
            return RedirectToAction("UserInfo", "Home", user);
        }

        // Rendering User view (second page)
        [HttpGet]
        public IActionResult UserInfo(UserInfoModel user)
        {
            return View("User", user);
        }

    }
}
