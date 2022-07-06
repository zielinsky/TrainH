using Microsoft.EntityFrameworkCore;

namespace TrainH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


    }
}
