using Microsoft.EntityFrameworkCore;
using Semana.Exercicios.Models.Configuration;
using Semana.Exercicios.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Components.Routing;



namespace School.Context;

public class SchoolContext : DbContext
{
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Student_Discipline> Students_Disciplines { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=CESARTELSKI-NOT\\SQLEXPRESS;Database=School;User ID=sa;Password=123321;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
        modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new QuizConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new Student_DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}