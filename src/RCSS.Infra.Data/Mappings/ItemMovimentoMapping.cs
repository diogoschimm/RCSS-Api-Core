using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities; 

namespace RCSS.Infra.Data.Mappings
{
    public class ItemMovimentoMapping : IEntityTypeConfiguration<ItemMovimento>
    {
        public void Configure(EntityTypeBuilder<ItemMovimento> builder)
        {
            builder.ToTable("CAD006_ITEM_MOVIMENTO");

            builder.HasKey(im => im.IdItemMovimento);

            builder.HasOne(im => im.Movimento).WithMany(m => m.ItemsMovimento).HasForeignKey(im => im.IdMovimento);
            builder.HasOne(im => im.Pessoa).WithMany(p => p.ItemsMovimento).HasForeignKey(im => im.IdPessoa);
            builder.HasOne(im => im.CentroCusto).WithMany(c => c.ItensMovimento).HasForeignKey(im => im.IdCentroCusto);
            builder.HasOne(im => im.PessoaPagador).WithMany(p => p.ItemsMovimentoComoPagador).HasForeignKey(im => im.IdPessoaPagador);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
