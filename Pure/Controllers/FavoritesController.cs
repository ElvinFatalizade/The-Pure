using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;

namespace Pure.Controllers
{
    public class FavoritesController : BaseController
    {
       
        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                Favirites = _context.Favirites.OrderBy(f => f.Id).ToList(),
                CodinBits = _context.CodinBits.OrderBy(f=> f.Id).ToList()
            
                
            };

            return View(model);
        }
    }
}