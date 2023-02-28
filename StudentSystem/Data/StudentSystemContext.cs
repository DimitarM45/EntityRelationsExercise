namespace P01_StudentSystem.Data;

using Models;
using Config;
using Microsoft.EntityFrameworkCore;

public class StudentSystemContext : DbContext
{
    public StudentSystemContext()
    {
    }

    public StudentSystemContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; } = null!;

    public DbSet<Course> Courses { get; set; } = null!;

    public DbSet<Resource> Resources { get; set; } = null!;

    public DbSet<Homework> Homeworks { get; set; } = null!;

    public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(DbConfig.ReadSettings());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property("Name")
                .IsUnicode()
                .HasMaxLength(100);

            entity.Property("PhoneNumber")
                .HasColumnType("char(10)");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property("Name")
                .IsUnicode()
                .HasMaxLength(80);

            entity.Property("Description")
                .IsUnicode();

            entity.Property("Price")
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.Property("Name")
                .IsUnicode()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(sc => new { sc.StudentId, sc.CourseId });
        });
    }
}
