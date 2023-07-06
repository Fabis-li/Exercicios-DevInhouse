namespace ProjetoMusicas.Api.DTOs;

public class AlbumDTO
{
    public string Nome { get; set; }
    public int AnoLancamento { get; set; }
    public string CapaUrl { get; set; }

    public List<MusicaAlbumDTO> Musicas { get; set; }
}
