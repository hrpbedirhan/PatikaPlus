using Identity_and_Data_Protection.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity_and_Data_Protection.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
