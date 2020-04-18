using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class StudentRegistrationService : IStudentRegistrationService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;
        public StudentRegistrationService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }
        public IList<StudentRegistration> GetStudentRegistrations(int id, int studentId, int courseId, DateTime enrollDate, bool isPaymentComplete)
        {
            IList<StudentRegistration> result = _registrationUnitOfWork.StudentRegistrationRepository.Get().ToList();
            return result;
        }
    }
}
