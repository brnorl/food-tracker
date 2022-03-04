using Microsoft.EntityFrameworkCore;

namespace foodtracker_db.Models
{
    public class FoodtrackerDbContext: DbContext
    {

        public FoodtrackerDbContext(DbContextOptions<FoodtrackerDbContext> options) :base(options)
        {     }
        public DbSet<Restorant> Restorants{get;set;}
        public DbSet<Comment> Comments{get;set;}
    }
 
}