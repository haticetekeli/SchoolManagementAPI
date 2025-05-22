namespace SchoolManagementAPI.Services.Teacher
{
    public interface TeacherService
    {
        void AddTeacher(Teacher teacher);
        List<Teacher> GetAllTeachers();
    }
}
