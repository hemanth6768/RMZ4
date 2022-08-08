using Microsoft.EntityFrameworkCore;
using RMZ.MODEL;

namespace RMZ.Context
{
    public class RMZContext:DbContext
    {
        public RMZContext(DbContextOptions<RMZContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }


        public DbSet<City> city { get; set; }
        public DbSet<Facility> facility { get; set; }

        public DbSet<Building> buildings { get; set; }

        public DbSet<Zone> zones { get; set; }

    }
}
