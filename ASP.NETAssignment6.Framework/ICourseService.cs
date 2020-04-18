using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETAssignment6.Framework
{
    public interface ICourseService
    {
        public IList<Course> GetCourse(int id, string title, int seatCount, int fee);
    }

}
