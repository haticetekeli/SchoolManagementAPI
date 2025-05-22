namespace SchoolManagementAPI.Services.Course
{
    public class CourseService
    {
        private List<CourseService> _courses = new();
        public void AddCourse(CourseService course) => _courses.Add(course);
        public List<CourseService> GetAllCourses() => _courses;
    }
}
