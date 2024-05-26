using Microsoft.EntityFrameworkCore;

namespace TravelAgency.Models
{
    public class DB_TravelAgency_5030 : DbContext
    {
        public DbSet<Airlines> Airlines { get; set; }
        public DbSet<Airplan> Airplans { get; set; }
        public DbSet<Airports> Airports { get; set; }
        public DbSet<OrderTypes> OrderTypes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Passanger> Passangers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB_TravelAgency_5030;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flights>()
                .HasOne(f => f.OriginAirport)
                .WithMany(a => a.OriginFlights)
                .HasForeignKey(f => f.OriginAirportId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Flights>()
                .HasOne(f => f.DestinationAirport)
                .WithMany(a => a.DestinationFlights)
                .HasForeignKey(f => f.DestinationAirportId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
