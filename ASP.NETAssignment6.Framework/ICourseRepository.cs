
using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface ICourseRepository: IRepository<Course>
    {
        IList<Course> GetLatestCourses();
    }
}
