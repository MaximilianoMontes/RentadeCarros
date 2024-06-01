using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RentadeCarros.Artefactos
{
    public class RentadeCarrosDBContext : DbContext
    {
        public RentadeCarrosDBContext(DbContextOptions<RentadeCarrosDBContext>options) : base(options) 
        {
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Reservaciones> Reservaciones { get; set; }

    }
}
