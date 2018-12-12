using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcViewData.Models;

namespace MvcViewData.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            
            return View();
        }
        [Route("info/{id}/{name}")]
        public ActionResult Panel(int id,string name)
        {
            List<string> persons = new List<string>();
            persons.Add("Naber 1");
            persons.Add("Naber 2");
            persons.Add("Naber 3");
            persons.Add("Naber 4");
            persons.Add("Naber 5");
            var bilgiler = new info()
            {
                personname = name,
                personid = id,                        
                persons = persons
            };
            return View(bilgiler);
        }
    }
}