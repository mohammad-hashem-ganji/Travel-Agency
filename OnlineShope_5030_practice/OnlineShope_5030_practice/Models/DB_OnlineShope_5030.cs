using Microsoft.EntityFrameworkCore;

namespace OnlineShope_5030_practice.Models
{
    public class DB_OnlineShope_5030 : DbContext
    {
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB_OnlineShope_5030;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
