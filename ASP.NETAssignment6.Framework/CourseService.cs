using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class CourseService: ICourseService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;

        public CourseService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public IList<Course> GetCourse(int id, string title, int seatCount, int fee)
        {
            var result = _registrationUnitOfWork.CourseRepository.Get().ToList();
            return result;
        }
    }
}
