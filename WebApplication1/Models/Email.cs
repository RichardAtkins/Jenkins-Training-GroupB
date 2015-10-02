using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Email
    {
        public string to { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string DeliveryType { get; set; }
    }
}