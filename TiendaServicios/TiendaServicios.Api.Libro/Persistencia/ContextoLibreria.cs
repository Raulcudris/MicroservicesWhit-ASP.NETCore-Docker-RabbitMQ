using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Libro.Modelo;

namespace TiendaServicios.Api.Libro.Persistencia
{
    public class ContextoLibreria: DbContext
    {
        public ContextoLibreria() { }
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options) { }
        public virtual DbSet<LibreriaMaterial> libreriaMaterial { get; set; }
    }
}
