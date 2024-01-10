
using GT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static GT.Domain.Entities.Tarefa;

namespace GT.Data.ContextConfig
{
    public class TarefaConfig : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {

            builder.ToTable("Tarefa");

            builder.HasKey(x => x.Id)
                .HasName("PK_Tarefa_id");

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.UsuarioId)
                .HasColumnName("usuarioId")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(x => x.Prioridade)
                .HasColumnName("prioridade")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(x => x.Titulo)
                .HasColumnName("titulo")
                .HasColumnType("varChar(50)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varChar(200)")
                .IsRequired();

            builder.Property(x => x.DataCadastro)
                .HasColumnName("dataCadastro")
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(x => x.DataConclusao)
                .HasColumnName("dataConclusao")
                .HasColumnType("DateTime");

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Tarefas)
                .HasForeignKey(x => x.UsuarioId)
                .HasConstraintName("FK_Tarefa_Usuario_id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(x => x.UsuarioId)
                .HasDatabaseName("IDX_Tarefa_usuarioId");

        }
    }
}
