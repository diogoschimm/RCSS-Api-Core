using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities; 

namespace RCSS.Infra.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("CAD005_PESSOA");

            builder.HasKey(m => m.IdPessoa);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
