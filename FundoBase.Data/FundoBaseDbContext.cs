using Microsoft.EntityFrameworkCore;

namespace FundoBase.Data
{
    public class FundoBaseDbContext : DbContext
    {
        public FundoBaseDbContext(DbContextOptions<FundoBaseDbContext> options)
            : base(options)
        {
        }

        // 👇 Adicione aqui os DbSets das entidades do domínio
        // public DbSet<Cliente> Clientes { get; set; }
        // public DbSet<Operacao> Operacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Exemplo de configuração modular:
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(FundoBaseDbContext).Assembly);
        }
    }
}
