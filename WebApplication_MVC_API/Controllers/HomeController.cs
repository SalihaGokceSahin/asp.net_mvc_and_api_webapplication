using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_MVC_API.Models;

namespace WebApplication_MVC_API.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MeetingForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MeetingForm(MeetingModel model)
        {
            if (ModelState.IsValid)
            {
                virtualDatabase.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }
        [ChildActionOnly]//we cant call it with url anymore.
        public ActionResult participants()
        {
            return PartialView(virtualDatabase.List.Where(i => i.participationStatus == true));
        }
    }
}