using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class RegistrationUnitOfWork : UnitOfWork<FrameworkContext>, IRegistrationUnitOfWork
    {
        public ICourseRepository CourseRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }
        public IStudentRegistrationRepository StudentRegistrationRepository { get; set; }

        public RegistrationUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            CourseRepository = new CourseRepository(_dbContext);
            StudentRepository = new StudentRepository(_dbContext);
            StudentRegistrationRepository = new StudentRegistrationRepository(_dbContext);
        }
    }
}
