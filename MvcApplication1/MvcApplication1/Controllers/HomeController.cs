using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Messages = "Hello ASP.NET MVC";
            
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {

            return View(guestResponse);
        }

        public ActionResult Thanks()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult MySpreadsheets()
        {

            SpreadsheetsService service = new SpreadsheetsService("chavp-mybook-1");
            service.setUserCredentials("iuityuj@rtrtey5e6yrty", "sdfdsfsdfsdf");

            WorksheetQuery query = new WorksheetQuery("0AsqxIqqTdYVidExTN0R0THh6XzlBa01pOURWVGRSMGc", "private", "full");
            WorksheetFeed feed = service.Query(query);

            List<Row> listData = new List<Row>();

            foreach (WorksheetEntry worksheet in feed.Entries)
            {
                AtomLink cellFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.CellRel, AtomLink.ATOM_TYPE);

                CellQuery cellQuery = new CellQuery(cellFeedLink.HRef.ToString());
                CellFeed cellFeed = service.Query(cellQuery);

                foreach (CellEntry curCell in cellFeed.Entries)
                {
                    Cell cell = new Cell { Row = curCell.Cell.Row, Index = curCell.Cell.Column, Data = curCell.Cell.Value };

                    var row = listData.Find(r => r.Index == curCell.Cell.Row);
                    if (row == null)
                    {
                        row = new Row { Index = curCell.Cell.Row };
                        listData.Add(row);
                    }

                    row.CellList.Add(cell);
                }
            }


            return View();
        }
    }
}
