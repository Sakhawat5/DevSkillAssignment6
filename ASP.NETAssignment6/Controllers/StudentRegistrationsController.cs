﻿using System;
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
            ViewData["CourseId"] = new SelectList(_storeContext.Courses, "Id", "Title");
            ViewData["StudentId"] = new SelectList(_storeContext.Students, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentRegistration studentRegistration)
        {
            _storeContext.Add(studentRegistration);
            _storeContext.SaveChanges();

            return RedirectToAction("Index", "studentRegistrations");
        }

        public IActionResult Edit(int id)
        {
            var registrations = _storeContext.StudentRegistrations.FirstOrDefault(x => x.Id == id);
            ViewData["CourseId"] = new SelectList(_storeContext.Courses, "Id", "Title");
            ViewData["StudentId"] = new SelectList(_storeContext.Students, "Id", "Name");

            return View(registrations);
        }

        [HttpPost]
        public IActionResult Edit(StudentRegistration studentRegistration)
        {
            _storeContext.StudentRegistrations.Update(studentRegistration);
            _storeContext.SaveChanges();

            ViewData["CourseId"] = new SelectList(_storeContext.Courses, "Id", "Title", studentRegistration.CourseId);
            ViewData["StudentId"] = new SelectList(_storeContext.Students, "Id", "Name", studentRegistration.StudentId);

            return RedirectToAction("Index", "StudentRegistrations");
        }
    }
}
