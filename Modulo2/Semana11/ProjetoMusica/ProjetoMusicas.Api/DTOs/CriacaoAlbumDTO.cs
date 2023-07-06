using System.ComponentModel.DataAnnotations;

namespace ProjetoMusicas.Api.DTOs;

public class CriacaoAlbumDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }
    [Range(1700, 3000, ErrorMessage = "O ano de lançamento é obrigatório.")]
    public int AnoLancamento { get; set; }
    public string CapaUrl { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "O artista é obrigatório.")]
    public int ArtistaId { get; set; }
    public List<MusicaAlbumDTO> Musicas { get; set; }
}
