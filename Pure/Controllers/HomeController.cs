using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;

namespace Pure.Controllers
{
    public class HomeController :BaseController
    {
        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                Populars = _context.Populars.OrderByDescending(p=> p.Id).ToList(),
                Ads = _context.Ads.OrderByDescending(a => a.Id).ToList(),
                Clients = _context.Clients.OrderByDescending(o => o.Id).ToList(),
                Recents = _context.Recents.OrderByDescending(r => r.Id).ToList(),
                CodinBits = _context.CodinBits.OrderBy(c => c.Id).ToList(),
                Promoteds =_context.Promoteds.OrderByDescending(z=> z.Id).ToList()
                
            };

            return View(model);
        }

      
    }
}