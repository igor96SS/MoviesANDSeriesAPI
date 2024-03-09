using Microsoft.EntityFrameworkCore;

namespace Movies_SeriesAPI.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) 
            : base(options)
        { 
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
