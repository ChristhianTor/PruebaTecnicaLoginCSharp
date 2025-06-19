using Microsoft.EntityFrameworkCore;

namespace ReportesMVC.Models
{
    public class BDReportesContext : DbContext
    {
        public BDReportesContext(DbContextOptions<BDReportesContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Persona> Personas { get; set; } = null!;
    }
}
