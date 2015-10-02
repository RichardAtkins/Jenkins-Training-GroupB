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
        public JsonResult Post([FromBody] Email input)
        {
            Email email = new Email
            {
                to = input.to,
                Subject = input.Subject,
                Message = input.Message,
                DeliveryType = input.DeliveryType 
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
