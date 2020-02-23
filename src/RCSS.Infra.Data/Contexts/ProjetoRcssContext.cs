using Microsoft.EntityFrameworkCore;
using RCSS.Domain.Entities;
using RCSS.Infra.Data.Mappings;

namespace RCSS.Infra.Data.Contexts
{
    public class ProjetoRcssContext : DbContext
    {
        public ProjetoRcssContext(DbContextOptions<ProjetoRcssContext> options) : base(options) { }

        public DbSet<Arquivo> Arquivo { get; set; }
        public DbSet<CentroCusto> CentroCusto { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<ItemMovimento> ItemMovimento { get; set; }
        public DbSet<Movimento> Movimento { get; set; }
        public DbSet<MovimentoEstoque> MovimentoEstoque { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArquivoMapping());
            modelBuilder.ApplyConfiguration(new CentroCustoMapping());
            modelBuilder.ApplyConfiguration(new ContaMapping());
            modelBuilder.ApplyConfiguration(new FornecedorMapping());
            modelBuilder.ApplyConfiguration(new ItemMovimentoMapping());
            modelBuilder.ApplyConfiguration(new MovimentoEstoqueMapping());
            modelBuilder.ApplyConfiguration(new MovimentoMapping());
            modelBuilder.ApplyConfiguration(new PessoaMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }
    }
}
