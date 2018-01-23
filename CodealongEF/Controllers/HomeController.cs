using CodealongEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodealongEF.Controllers
{
    public class HomeController : Controller
    {
        PeopleDbContext db = new PeopleDbContext();



        // GET: Home
        public ActionResult Index()
        {
            List<Person> myList = db.people.ToList();

            return View(myList);
        }

        public ActionResult Create()
        {
            Person me = new Person();
            me.Name = "Bobbo";
            me.Age = 99;

            db.people.Add(me); //adds something to a DB (database)
            db.SaveChanges(); //saves changes (add Bobbo)

            return RedirectToAction("Index");
        }

    }
}