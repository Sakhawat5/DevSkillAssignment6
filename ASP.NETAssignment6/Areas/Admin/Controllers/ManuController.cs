using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETAssignment6.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETAssignment6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManuController : Controller
    {
        public IActionResult Index()
        {
            var menuModel = new MenuModel();
            return View(menuModel);
        }
    }
}