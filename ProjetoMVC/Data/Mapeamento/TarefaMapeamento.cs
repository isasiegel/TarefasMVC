using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data.Mapeamento
{
    public class TarefaMapeamento : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)

        {

            builder.ToTable("Tarefa");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Titulo).HasColumnType("varchar(20)");

            builder.Property(t => t.Descricao).HasColumnType("varchar(150)");

            builder.Property(t => t.Prazo).HasColumnType("date");

        }

    }
}
