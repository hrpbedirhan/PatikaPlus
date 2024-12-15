using CodeFirstBasic.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Model
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb1;Username=postgres;Password=[Your_Password]");
        }

    }
}
