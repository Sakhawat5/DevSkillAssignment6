
using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext): base (dbContext)
        {

        }

        public IList<Student> GetLatestStudents()
        {
            throw new NotImplementedException();
        }
    }
}
