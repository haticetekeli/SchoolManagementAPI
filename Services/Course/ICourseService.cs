using System.Collections.Generic;
using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Services.Courses
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        List<Course> GetAllCourses();
    }
}

