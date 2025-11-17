using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        Fall25_CEntities db = new Fall25_CEntities();
        public ActionResult Index()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }
        [HttpPost]
        public ActionResult Register(int[] Courses) {
            var stId = 1; //session 
            var reg = new Registration() { 
                Status="Pre-Reg",
                Date = DateTime.Now,
                StudentId = stId,
            };
            db.Registrations.Add(reg);
            db.SaveChanges();
            foreach (var item in Courses)
            {
                var courseStudent = new CourseStudent() { 
                    RegId = reg.Id,
                    SId = stId,
                    CId = item
                };
                db.CourseStudents.Add(courseStudent);
            }
            db.SaveChanges();
            return RedirectToAction("Courses","Student");
        }
    }
}