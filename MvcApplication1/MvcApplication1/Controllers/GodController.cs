using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GodLibrary;

namespace MvcApplication1.Controllers
{
    public class GodController : Controller
    {
        //
        // GET: /God/

        public ActionResult Index()
        {
            return View(new God());
        }

    }
}
