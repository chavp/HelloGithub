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

        public ActionResult Humans()
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Human { Name = "Human_1", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_2", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_3", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_4", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_5", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_6", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_7", Bod = DateTime.Now });
            humans.Add(new Human { Name = "Human_8", Bod = DateTime.Now });
            return View(humans);
        }
    }
}
