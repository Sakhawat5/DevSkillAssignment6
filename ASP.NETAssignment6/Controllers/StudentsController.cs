﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETAssignment6.Data;
using ASP.NETAssignment6.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASP.NETAssignment6.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StoreContext _storeContext;
        public StudentsController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public IActionResult Index()
        {
            List<Student> students = _storeContext.Students.ToList();
            
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _storeContext.Students.Add(student);
            _storeContext.SaveChanges();
            return View(student);
        }
    }
}