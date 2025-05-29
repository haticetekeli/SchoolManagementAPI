using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Services.Courses
{
    public class CourseService : ICourseService
    {
        public List<Course> _courses = new();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAllCourses() => _courses;

        List<Course> ICourseService.GetAllCourses()
        {
            throw new NotImplementedException();
        }
    }
}
