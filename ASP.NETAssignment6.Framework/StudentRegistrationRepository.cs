using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class StudentRegistrationRepository : Repository<StudentRegistration>, IStudentRegistrationRepository
    {
        public StudentRegistrationRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public IList<StudentRegistration> GetLatestStudentRegistration()
        {
            throw new NotImplementedException();
        }
    }
}
