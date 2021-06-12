using garage.Models;
using Microsoft.EntityFrameworkCore;

namespace garage.Persistence
{
    public class GarageDbContext: DbContext
    {
        public GarageDbContext(DbContextOptions<GarageDbContext> options):base(options)
        {
            
        }

        public DbSet<Make> Makes {get; set;}
    }
}