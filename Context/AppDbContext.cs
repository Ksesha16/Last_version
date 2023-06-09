using Microsoft.EntityFrameworkCore;
using WEB.Models;

namespace WEB.Context
{

    public class AppDbContext : DbContext
    {
        public DbSet<User>Users{ get; set; }
        public DbSet<Role> Roles{ get; set; }
        public DbSet<Products> Product { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = System.IO.Path.GetFullPath("app.db");
            optionsBuilder.UseSqlite("Filename = " + dbPath);

        }
    }

}
