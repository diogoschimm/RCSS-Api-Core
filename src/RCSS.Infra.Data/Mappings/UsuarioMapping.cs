using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSS.Domain.Entities;

namespace RCSS.Infra.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("SYS001_USUARIO");

            builder.HasKey(u => u.UsuarioId);

            builder.Ignore(tbl => tbl.Notifications);
            builder.Ignore(tbl => tbl.Invalid);
            builder.Ignore(tbl => tbl.Valid);
        }
    }
}
