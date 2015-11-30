using Epam.Training.Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epam.Training.Day14.Controllers
{
    public class HomeController : Controller
    {
        Trainings db = new Trainings();

        public ActionResult Index()
        {
            IEnumerable<Cours> courses = db.Courses;
            ViewBag.Courses = courses.ToArray();
            return View();
        }

    }
}