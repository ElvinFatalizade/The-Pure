using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;
using Pure.Data;
using Pure.Models;

namespace Pure.Controllers
{
    public class ViewStoreController : BaseController
    {
        // GET: ViewStore
        public ActionResult Index()
        {
            Homepage homepage = new Homepage
            {
                Promoteds = _context.Promoteds.OrderByDescending(m => m.Id).ToList(),
                                          
        };
            return View(homepage);
        }

       
        
    }
}