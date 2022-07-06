using Microsoft.EntityFrameworkCore;
using TrainH.Models;

namespace TrainH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseData> ExerciseDatas { get; set; }
        public DbSet<History> History { get; set; }
    }
}
