using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data.Entities;
using School.Data.Interfaces;

namespace School.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseDb courseDb;

        public CourseController(ICourseDb courseDb)
        {
            this.courseDb = courseDb;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            var courses = this.courseDb.GetCourses();
            return View(courses);
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            var course = this.courseDb.GetCourse(id);
            return View(course);
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                this.courseDb.SaveCourse(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            var course = this.courseDb.GetCourse(id);
            return View(course);
             
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            try
            {
                this.courseDb.UpdateCourse(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
