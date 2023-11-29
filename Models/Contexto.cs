using Microsoft.EntityFrameworkCore;

namespace Projeto_final.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        // public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }


    }
}
