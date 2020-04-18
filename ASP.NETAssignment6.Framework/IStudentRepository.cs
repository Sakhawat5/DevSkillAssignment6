using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IStudentRepository : IRepository<Student>
    {
        IList<Student> GetLatestStudents();
    }
}
