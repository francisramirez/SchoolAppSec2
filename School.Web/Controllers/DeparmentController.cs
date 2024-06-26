using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data.Entities;
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
            var department = this.daoDepartment.GetDepartment(id);
            return View(department);
        }

        // GET: DeparmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeparmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                this.daoDepartment.SaveDepartment(department);
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
            var department = this.daoDepartment.GetDepartment(id);
            return View(department);
        }

        // POST: DeparmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            try
            {
                this.daoDepartment.UpdateDepartment(department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
