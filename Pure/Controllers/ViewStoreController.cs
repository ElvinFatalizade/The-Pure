using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pure.Controllers
{
    public class ViewStoreController : Controller
    {
        // GET: ViewStore
        public ActionResult Index()
        {
            return View();
        }
    }
}