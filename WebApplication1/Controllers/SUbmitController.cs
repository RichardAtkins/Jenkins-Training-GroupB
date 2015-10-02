using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SubmitController : ApiController
    {
        // POST api/values
        public JsonResult Post()
        {



            Email email = new Email
            {
                to = "richarda@nvisionit.co.za",
                Subject = "Are you Alive",
                Message = "PLease respond at your earliest convenience",
                DeliveryType = "Email"
            };
            var result = new JsonResult 
            {
                Data = email
            };
            return result;
            //return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
