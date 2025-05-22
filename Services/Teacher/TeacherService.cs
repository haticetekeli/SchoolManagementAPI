namespace SchoolManagementAPI.Services.Teacher
{
    public class TeacherService
    {
        private List<TeacherService> _teachers = new();
        public void AddTeacher(TeacherService teacher) => _teachers.Add(teacher);
        public List<TeacherService> GetAllTeachers() => _teachers;
    }
}

