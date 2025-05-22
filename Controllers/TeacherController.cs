using Microsoft.AspNetCore.Mvc;
using SchoolManagementAPI.Models;
using SchoolManagementAPI.Services.Teacher;

namespace SchoolManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_teacherService.GetAllTeachers());

        [HttpPost]
        public IActionResult Add(Teacher teacher)
        {
            _teacherService.AddTeacher(teacher);
            return Ok();
        }
    }
}