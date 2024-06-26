using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data.Interfaces;

namespace School.Web.Controllers
{
    public class DeparmentController : Controller
    {
        private readonly IDaoDepartment daoDepartment;

        public DeparmentController(IDaoDepartment daoDepartment)
        {
            this.daoDepartment = daoDepartment;
        }
        // GET: DeparmentController
        public ActionResult Index()
        {
            var departments = this.daoDepartment.GetDepartments();  
            return View(departments);
        }

        // GET: DeparmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeparmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeparmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeparmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeparmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeparmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeparmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
