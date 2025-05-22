namespace SchoolManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Courses { get; set; } = new();
        public List<Grade> Grades { get; set; } = new();
    }
}
