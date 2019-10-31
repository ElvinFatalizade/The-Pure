using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;

namespace Pure.Controllers
{
    public class StoreController : BaseController
    {
        // GET: Store
        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                ChooseCategories = _context.ChooseCategories.OrderBy(c => c.Id).ToList(),
                Promoteds =_context.Promoteds.OrderBy(c=> c.Id).ToList()
            };

            return View(model);
        }
    }
}