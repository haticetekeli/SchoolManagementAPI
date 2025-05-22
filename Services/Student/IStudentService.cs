using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Services.StudentService
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student FindStudentByName(string name);
        double CalculateAverageGrade(Student student);
        void SaveToFile();
        void LoadFromFile();
    }

}
