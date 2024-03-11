using Microsoft.EntityFrameworkCore;

namespace Movies_SeriesAPI.Models
{
    public class SeriesContext : DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options) 
            : base(options) 
        { 
        }

        public DbSet<Series> Series { get; set; }
    }
}
