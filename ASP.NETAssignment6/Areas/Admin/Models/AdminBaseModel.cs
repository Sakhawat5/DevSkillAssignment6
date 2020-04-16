using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETAssignment6.Areas.Admin.Models
{
    public class AdminBaseModel
    {
        public AdminBaseModel()
        {
            MenuModel = new MenuModel();
        }
        public MenuModel MenuModel { get; set; }

    }
}
