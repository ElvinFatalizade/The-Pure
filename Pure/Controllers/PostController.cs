using Pure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pure.ViewsModels;
using System.IO;

namespace Pure.Controllers
{
    public class PostController : BaseController
    {

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Ads ads)
        {
            if (ads.File.ContentType != "image/jpeg" && ads.File.ContentType != "image/png" && ads.File.ContentType != "image/jpg")
            {
                ModelState.AddModelError("File", "Sekil formati duzgun deyil");
            }

            if (ads.File.ContentLength / 1024 / 1024 > 1)
            {
                ModelState.AddModelError("Fiel", "Max sie 1mb");
            }

            if (ModelState.IsValid)
            {
                var text = ads.File.FileName.Split('.');
                ads.Photo = Guid.NewGuid().ToString() + "." + text[text.Length - 1];


                string path = Path.Combine(Server.MapPath("/Uploads"), ads.Photo);

                ads.File.SaveAs(path);


                _context.Ads.Add(ads);
                _context.SaveChanges();

                return RedirectToAction("index", "home");
            }
            return View(ads);
        }
        //[HttpPost]
        //public ActionResult Create(Ads ads)
        //{
          
        //        _context.Ads.Add(ads);
        //        _context.SaveChanges();
        //        return RedirectToAction("index", "home");
        //    }
        //    return View(ads);
        //}
    }
}