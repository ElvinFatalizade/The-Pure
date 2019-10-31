using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;

namespace Pure.Controllers
{
    public class ProfileController : BaseController
    {
       
        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                Promoteds = _context.Promoteds.OrderBy(a => a.Id).ToList(),
                CodinBits = _context.CodinBits.OrderBy(c => c.Id).ToList(),
                ChooseCategories =_context.ChooseCategories.OrderBy(c=> c.Id).ToList()
            };

            return View(model);
        }
    }
}