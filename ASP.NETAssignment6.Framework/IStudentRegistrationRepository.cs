using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IStudentRegistrationRepository : IRepository<StudentRegistration>
    {
        IList<StudentRegistration> GetLatestStudentRegistration();
    }
}
