using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options) 
        { 
        }   

        public DbSet<Application> Applications { get; set; }
    }
}
