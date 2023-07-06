using ProjetoMusicas.Api.Models;

namespace ProjetoMusicas.Api.ViewModels;

public class AlbumComMusicasViewModel
{
    private Album album;

    public AlbumComMusicasViewModel(Album album)
    {
        Id = album.Id;
        Nome = album.Nome;
        AnoLancamento = album.AnoLancamento;
        CapaUrl = album.CapaUrl;
        Musicas = album?.Musicas.Select(musica => new AlbumMusicasViewModel(){
            Id = musica.Id,
            Nome = musica.Nome,
            Duracao = musica.Duracao
        }).ToList();


    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int AnoLancamento { get; set; }
    public string CapaUrl { get; set; }

    public List<AlbumMusicasViewModel> Musicas { get; set; }
}
