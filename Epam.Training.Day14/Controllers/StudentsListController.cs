using Epam.Training.Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epam.Training.Day14.Controllers
{
    public class StudentsListController : Controller
    {
        Trainings db = new Trainings();

        public ActionResult Index(int? id)
        {
            ViewBag.Cours = db.Courses.Single(c => c.Id == id);
            var sList = db.Records.Where(r => r.CourseId == id).Join(db.Students, r => r.StudentId, s => s.Id, (r, s) => s);
            return View(sList);
        }
    }
}