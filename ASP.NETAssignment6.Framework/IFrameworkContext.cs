using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IFrameworkContext
    {
        DbSet<Course> Courses { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<StudentRegistration> StudentRegistrations { get; set; }
    }
}
