using Microsoft.EntityFrameworkCore;
using garage.Controllers;

namespace garage.Persistence
{
    public class garageDbContext : DbContext
    {
        public garageDbContext(DbContextOptions<garageDbContext> options): base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        
    }
}