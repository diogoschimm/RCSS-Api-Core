using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities;

namespace RCSS.Infra.Data.Mappings
{
    public class MovimentoMapping : IEntityTypeConfiguration<Movimento>
    {
        public void Configure(EntityTypeBuilder<Movimento> builder)
        {
            builder.ToTable("CAD001_MOVIMENTO");

            builder.HasKey(m => m.IdMovimento);

            builder.HasOne(m => m.Conta).WithMany(c => c.Movimentos).HasForeignKey(m => m.IdConta);
            builder.HasOne(m => m.Fornecedor).WithMany(f => f.Movimentos).HasForeignKey(m => m.IdFornecedor);
            builder.HasOne(m => m.CentroCusto).WithMany(c => c.Movimentos).HasForeignKey(m => m.IdCentroCusto);
            builder.HasOne(m => m.Pessoa).WithMany(p => p.Movimentos).HasForeignKey(m => m.IdPessoa);
            builder.HasOne(m => m.PessoaPagador).WithMany(p => p.MovimentosComoPagador).HasForeignKey(m => m.IdPessoaPagador);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
