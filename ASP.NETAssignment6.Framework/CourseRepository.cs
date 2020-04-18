using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext dbContext)
           : base(dbContext)
        {

        }

        public IList<Course> GetLatestCourses()
        {
            throw new NotImplementedException();
        }
    }
}
