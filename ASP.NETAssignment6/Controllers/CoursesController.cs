using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETAssignment6.Data;
using ASP.NETAssignment6.Framework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETAssignment6.Controllers
{
    public class CoursesController : Controller
    {
        private readonly StoreContext _storeContext;
        public CoursesController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            _storeContext.Courses.Add(course);
            _storeContext.SaveChanges();

            return View(course);
        }
    }
}