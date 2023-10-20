using BusLocator.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusLocator.Core
{
    public class BusLocatorContext : DbContext
    {
        public BusLocatorContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Line> Lines { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<LineStop> LineStops { get; set; }
    }
}