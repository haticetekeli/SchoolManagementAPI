namespace SchoolManagementAPI.Services.Course
{
    public interface ICourseService
    {
        void AddCourse(ICourseService course);
        List<ICourseService> GetAllCourses();
    }
}
