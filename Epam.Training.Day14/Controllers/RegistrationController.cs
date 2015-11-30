using Epam.Training.Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epam.Training.Day14.Controllers
{
    public class RegistrationController : Controller
    {
        Trainings db = new Trainings();

        [HttpGet]
        public ActionResult Register(int? id)
        {
            SelectList univers = new SelectList(db.Universities, "Id", "Name");
            ViewBag.Universities = univers;
            var cours = from c in db.Courses where c.Id == id select c;
            ViewBag.Cours = cours.First();
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student st, int? id)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(st);
                db.Records.Add(new Record { StudentId = st.Id, CourseId = id.Value });
                db.SaveChanges();
                ViewBag.Cours = db.Courses.Find(id);
                return View("Success", st);
            }
            SelectList univers = new SelectList(db.Universities, "Id", "Name");
            ViewBag.Universities = univers;
            var cours = from c in db.Courses where c.Id == id select c;
            ViewBag.Cours = cours.First();
            return View(st);
        }
    }
}