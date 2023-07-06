using Microsoft.EntityFrameworkCore;
using ProjetoMusicas.Api.Models;

namespace ProjetoMusicas.Api.Data;

public class ProjetoDbContext : DbContext
{
    private IConfiguration _configuration;

    public ProjetoDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Album> Albuns { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<PlaylistMusica> PlaylistMusicas { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DB_MUSICAS"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

          modelBuilder.Entity<Artista>(entidade =>
        {
            entidade.ToTable("Artistas");

            entidade.HasKey(a => a.Id);

            entidade
                .Property(a => a.Nome)
                .HasMaxLength(120)
                .IsRequired();

            entidade
                .Property(a => a.NomeArtistico)
                .HasMaxLength(120);

            entidade
                .Property(a => a.FotoUrl)
                .HasMaxLength(80);

            entidade
                .HasData(new[]{
                    new Artista{
                        Id = 1,
                        Nome = "Michael Jackson",
                        NomeArtistico = "Michael Jackson",
                        FotoUrl = null,                        
                    },
                    new Artista{
                        Id = 2,
                        Nome = "Elvis Presley",
                        NomeArtistico = "Elvis Presley",
                        FotoUrl = null,                        
                    },
                });
        });

        modelBuilder.Entity<Album>(entidade =>
        {
            entidade.ToTable("Albuns");

            entidade.HasKey(a => a.Id);

            entidade
                .Property(a => a.Nome)
                .HasMaxLength(120)
                .IsRequired();

            entidade
                .Property(a => a.AnoLancamento)
                .IsRequired();

            entidade
                .Property(a => a.CapaUrl)
                .HasMaxLength(80);

            entidade
                .HasOne(album => album.Artista)
                .WithMany(artista => artista.Albuns)
                .HasForeignKey(album => album.ArtistaId);
        });  

        modelBuilder.Entity<Musica>(entidade => {
            entidade.ToTable("Musicas");

            entidade.HasKey(m => m.Id);

            entidade
                .Property(m => m.Nome)
                .HasMaxLength(120)
                .IsRequired();

            entidade.Property(m => m.Duracao);

            entidade
                .HasOne(m => m.Album)
                .WithMany(a => a.Musicas)
                .HasForeignKey(m => m.AlbumId);

            entidade
                .HasOne(m => m.Artista)
                .WithMany(a => a.Musicas)
                .HasForeignKey(m => m.ArtistaId);
        });  
    } 
        
}
