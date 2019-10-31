using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}