using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities; 

namespace RCSS.Infra.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("CAD008_PRODUTO");

            builder.HasKey(m => m.IdProduto);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
