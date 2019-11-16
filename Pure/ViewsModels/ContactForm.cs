using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pure.ViewsModels
{
    public class ContactForm
    {
        public string Fullname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}