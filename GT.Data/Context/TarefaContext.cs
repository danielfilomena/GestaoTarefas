using GT.Data.ContextConfig;
using GT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GT.Data.Context
{
    public class TarefaContext : DbContext
    {

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new TarefaConfig());

        }

    }
}
