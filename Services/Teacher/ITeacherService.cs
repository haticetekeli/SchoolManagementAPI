using System.Collections.Generic;
using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Services.Teachers
{
    public interface ITeacherService
    {
        void Add(Models.Teacher teacher);
        List<Models.Teacher> GetAllTeachers();
    }
}
