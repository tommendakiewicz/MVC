using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //default home page
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 12 ? "Good morning" : "Good afternoon";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
          return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
          if (ModelState.IsValid)
          {
            return View("Thanks", guestResponse);
          } else
          {
            // validation error
            return View();
          }
        }
    }
}
