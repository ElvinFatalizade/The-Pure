using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;

namespace Pure.Controllers
{
    public class ContactController : BaseController
    {

        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                CodinBits = _context.CodinBits.OrderBy(c => c.Id).ToList()
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ContactForm conform)
        {

            var body = "<p>Fullname From: {0} ({1})</p><p>Email:</p><p>Phone:</p><p>{2}</p><p>Message:</p><p>{3}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("elvinff@code.edu.az"));  // replace with valid value 
            message.From = new MailAddress("qwertyfatalizade@gmail.com");  // replace with valid value
            message.Subject = "Your email subject";
            message.Body = string.Format(body, conform.Fullname, conform.Phone, conform.Email, conform.Message);
            message.IsBodyHtml = true;


            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "qwertyfatalizade@gmail.com",  // replace with valid value
                    Password = "*******"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
                return Content("Sent");

                ;
            }



        }
    }
}