using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IStudentService
    {
        public IList<Student> GetStudent(int id, string name, DateTime dateOfBirth);
    }
}
