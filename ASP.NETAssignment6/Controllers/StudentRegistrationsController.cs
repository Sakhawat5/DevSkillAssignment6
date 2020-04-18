using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NETAssignment6.Data;
using ASP.NETAssignment6.Framework;

namespace ASP.NETAssignment6.Controllers
{
    public class StudentRegistrationsController : Controller
    {
        private readonly StoreContext _storeContext;

        public StudentRegistrationsController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public IActionResult Index()
        {
            var storeContext = _storeContext.StudentRegistrations.Include(s => s.Course).Include(s => s.Student);
            return View(storeContext.ToList());
        }

        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_storeContext.Courses, "Id", "Id");
            ViewData["StudentId"] = new SelectList(_storeContext.Students, "Id", "Id");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentRegistration studentRegistration)
        {
            _storeContext.Add(studentRegistration);
            _storeContext.SaveChanges();

            ViewData["CourseId"] = new SelectList(_storeContext.Courses, "Id", "Id", studentRegistration.CourseId);
            ViewData["StudentId"] = new SelectList(_storeContext.Students, "Id", "Id", studentRegistration.StudentId);
            return View(studentRegistration);
        }

    }
}
