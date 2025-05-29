using SchoolManagementAPI.Models;
using SchoolManagementAPI.Services.Teachers;

namespace SchoolManagementAPI.Services.Teacher
{
    public class TeacherService : ITeacherService
    {
        public List<Models.Teacher> _teachers = new();

        public void Add(Models.Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public List<Models.Teacher> GetAllTeachers() => _teachers;
    }
}
