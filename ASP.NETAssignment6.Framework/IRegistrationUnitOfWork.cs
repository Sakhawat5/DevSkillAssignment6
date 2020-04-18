using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface IRegistrationUnitOfWork : IUnitOfWork<FrameworkContext>
    {
        ICourseRepository CourseRepository { get; set; }
        IStudentRepository StudentRepository { get; set; }
        IStudentRegistrationRepository StudentRegistrationRepository { get; set; }
    }
}
