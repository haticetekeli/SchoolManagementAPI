using Microsoft.EntityFrameworkCore;
using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Student modeli için yapılandırma
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired();

            // Teacher modeli için yapılandırma
            modelBuilder.Entity<Teacher>()
                .Property(t => t.Name)
                .IsRequired();

            // Course modeli için yapılandırma
            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Teacher)
                .IsRequired();

            // Grade modeli için yapılandırma
            modelBuilder.Entity<Grade>()
                .Property(g => g.CourseName)
                .IsRequired();

            // User modeli için yapılandırma
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
        }
    }
} 