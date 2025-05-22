using SchoolManagementAPI.Models;
using System.Text.Json;
namespace SchoolManagementAPI.Services.StudentService;
public class StudentService : IStudentService
{
    private List<Student> _students = new();
    private readonly string _filePath = "students.json";

    public StudentService()
    {
        LoadFromFile();
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
        SaveToFile();
    }

    public List<Student> GetAllStudents() => _students;

    public Student FindStudentByName(string name) =>
        _students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    public double CalculateAverageGrade(Student student)
    {
        if (!student.Grades.Any()) return 0;
        return student.Grades.Average(g => g.Score);
    }

    public void SaveToFile()
    {
        var json = JsonSerializer.Serialize(_students);
        File.WriteAllText(_filePath, json);
    }

    public void LoadFromFile()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            var data = JsonSerializer.Deserialize<List<Student>>(json);
            if (data != null) _students = data;
        }
    }
}