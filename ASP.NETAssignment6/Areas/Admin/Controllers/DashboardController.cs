using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETAssignment6.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETAssignment6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var dashboardModel = new DashboardModel();
            return View(dashboardModel);
        }
    }
}