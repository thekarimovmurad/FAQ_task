using FAQ_task.DAL;
using FAQ_task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_task.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {

            List<FAQ> faqs=db.FAQs.ToList();


            return View(faqs);
            //List<FAQ> faqs = new List<FAQ>
            //{
            //    new FAQ(1, "Accordion Item #1","Placeholder content for this accordion, which is intended to demonstrate the."),
            //    new FAQ(2, "Accordion Item #2","Placeholder content for this accordion, which is intended to demonstrate the."),
            //    new FAQ(3, "Accordion Item #3","Placeholder content for this accordion, which is intended to demonstrate the.")
            //};

            //return View(faqs);
        }
    }
}
