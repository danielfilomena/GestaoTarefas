using GT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GT.Data.ContextConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id)
                .HasName("PK_Usuario_Id");

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("VarChar(10)")
                .IsRequired();

        }

    }

}
