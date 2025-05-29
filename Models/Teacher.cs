namespace SchoolManagementAPI.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Course { get; set; } = new();
    }
}
