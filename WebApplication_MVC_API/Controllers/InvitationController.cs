using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_MVC_API.Models;

namespace WebApplication_MVC_API.Controllers
{
    public class InvitationController : ApiController
    {
        //[HttpGet]
        public IEnumerable<MeetingModel> GetAttendees()
        {
            return virtualDatabase.List.Where(i => i.participationStatus == true);
        }
        //[HttpGet]
        public IEnumerable<MeetingModel> GetNotAttendees()
        {
            return virtualDatabase.List.Where(i => i.participationStatus == false);
        }
        [HttpPost]
        public void Addd(MeetingModel model)
        {
            if (ModelState.IsValid)
            {
                virtualDatabase.Add(model);
            }
            //virtualDatabase.Add(model);
        }
    }
}
