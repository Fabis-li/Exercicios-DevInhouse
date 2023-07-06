using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musica.Domain.Models;

namespace Musica.Infra.DataBase.Mappings
{
    public class BandaMap : IEntityTypeConfiguration<BandaModel>
    {
        public void Configure(EntityTypeBuilder<BandaModel>builder)
        {
            builder.ToTable("MUSICAS");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int");
            
            builder.Property(m => m.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(200);

            builder.Property(m => m.NomeMusica)
                    .HasColumnName("NOME_MUSICA")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(50);

            builder.Property(m => m.SequenciaMusica)
                    .HasColumnName("SEQUENCIA_MUSICA")
                    .HasColumnType("int");
        }
    }
}