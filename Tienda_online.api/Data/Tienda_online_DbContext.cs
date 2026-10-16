using Microsoft.EntityFrameworkCore;
using Tienda_online.api.Models;

namespace Tienda_online.api.Data
{
    public class Tienda_online_DbContext : DbContext
    {
        public Tienda_online_DbContext(DbContextOptions<Tienda_online_DbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Proveedores> Proveedores { get; set; } = null!;
        public DbSet<MetodosPago> MetodosPago { get; set; } = null!;

    }
}