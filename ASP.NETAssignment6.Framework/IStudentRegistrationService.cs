using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IStudentRegistrationService 
    {
        public IList<StudentRegistration> GetStudentRegistrations(int id, int studentId, int courseId, DateTime enrollDate, bool isPaymentComplete);
    }
}
