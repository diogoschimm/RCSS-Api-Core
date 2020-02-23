using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities;

namespace RCSS.Infra.Data.Mappings
{
    public class CentroCustoMapping : IEntityTypeConfiguration<CentroCusto>
    {
        public void Configure(EntityTypeBuilder<CentroCusto> builder)
        {
            builder.ToTable("CAD002_CENTRO_CUSTO");

            builder.HasKey(c => c.IdCentroCusto);
            builder.Property(c => c.IdCentroCusto).ValueGeneratedOnAdd();

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
