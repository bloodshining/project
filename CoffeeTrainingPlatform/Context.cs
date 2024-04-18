using Microsoft.EntityFrameworkCore;
using CoffeeTraining.Models;
using CoffeeTrainingPlatform.Models;


namespace CoffeeTraining
{
    public class CoffeeTrainingPlatformDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Documents> Documents { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Progress> Progress { get; set; } = null!;
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<PracticeTest> practiceTests { get; set; } = null!;

        public DbSet<DocumentContent> DocumentContent { get; set; } = null!;

        public DbSet<TestAnswers> TestAnswers { get; set; } = null!;
        public DbSet<TestQuestions> TestQuestions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CoffeeTrainingPlatformdb;Username=postgres;Password=1234");
        }
    }
}