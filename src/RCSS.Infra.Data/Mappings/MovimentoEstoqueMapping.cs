using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities; 

namespace RCSS.Infra.Data.Mappings
{
    public class MovimentoEstoqueMapping : IEntityTypeConfiguration<MovimentoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentoEstoque> builder)
        {
            builder.ToTable("CAD009_MOVIMENTO_ESTOQUE");

            builder.HasKey(m => m.IdMovimentacao);

            builder.HasOne(m => m.Produto).WithMany(p => p.MovimentosEstoque).HasForeignKey(m => m.IdProduto);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
