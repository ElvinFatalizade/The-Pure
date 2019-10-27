using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pure.Controllers
{
    public class RecentViewAllController : BaseController
    {
        // GET: RecentViewAll
        public ActionResult Index()
        {
            return View();
        }
    }
}