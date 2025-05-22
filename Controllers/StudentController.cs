using Microsoft.AspNetCore.Mvc;
using SchoolManagementAPI.Models;
using SchoolManagementAPI.Services.StudentService;

namespace SchoolManagementAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_studentService.GetAllStudents());

    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        _studentService.AddStudent(student);
        return Ok();
    }

    [HttpGet("{name}/average")]
    public IActionResult GetAverage(string name)
    {
        var student = _studentService.FindStudentByName(name);
        if (student == null) return NotFound();
        var average = _studentService.CalculateAverageGrade(student);
        return Ok(new { student.Name, Average = average });
    }
}
