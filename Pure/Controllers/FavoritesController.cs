﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pure.Controllers
{
    public class FavoritesController : BaseController
    {
        // GET: Favorites
        public ActionResult Index()
        {
            return View();
        }
    }
}