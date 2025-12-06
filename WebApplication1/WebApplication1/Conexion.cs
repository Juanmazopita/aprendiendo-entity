using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1
{
    public class Conexion : DbContext
    {
        public Conexion(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Mascotas>Mascotas => Set<Mascotas>();
        public DbSet<Doctores>Doctores => Set<Doctores>();
        public DbSet<Consultas>Consultas => Set<Consultas>();
    }
}
