using Pure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pure.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ThePureContext _context;
      

        public BaseController()
        {
            _context = new ThePureContext();

            ViewBag.SocialLink = _context.SocialLinks.OrderBy(sl => sl.OrderBy).ToList();
            ViewBag.Setting = _context.Settings.FirstOrDefault();
        }
    }
}