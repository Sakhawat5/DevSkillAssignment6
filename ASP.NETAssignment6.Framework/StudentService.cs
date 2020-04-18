using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASP.NETAssignment6.Framework
{
    public class StudentService : IStudentService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;
        public StudentService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public IList<Student> GetStudent(int id, string name, DateTime dateOfBirth)
        {
            IList<Student> resutl = _registrationUnitOfWork.StudentRepository.Get().ToList();
            return resutl;
        }
    }
}
