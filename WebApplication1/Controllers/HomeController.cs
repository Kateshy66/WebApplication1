using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var db = new Db();
            var list = db.Animals.Where(a => a.LegsCount < 100).ToList();
            return View(list);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult SaveAnimal(Animal animal)
        {
            var db = new Db();
            if(animal.Id == 0)
            {
                db.Animals.Add(animal);
                db.SaveChanges();

            }

            else
            {


            }

            return View("Index");

        }
    }
}