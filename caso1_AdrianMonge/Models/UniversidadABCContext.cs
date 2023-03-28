using Microsoft.EntityFrameworkCore;

namespace caso1_AdrianMonge.Models;


public class UniversidadABCContext : DbContext
{
    public UniversidadABCContext(DbContextOptions<UniversidadABCContext> options)
    : base(options)
    {
    }

    public DbSet<Asignatura> Asignaturas { get; set; }
}

