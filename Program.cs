using SchoolManagementAPI.Services.Course;
using SchoolManagementAPI.Services.StudentService;
using SchoolManagementAPI.Services.Teacher;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IStudentService, StudentService>();
builder.Services.AddSingleton<ITeacherService, TeacherService>();
builder.Services.AddSingleton<ICourseService, CourseService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();