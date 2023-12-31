using System.ComponentModel.DataAnnotations;

namespace ProjetoMusicas.Api.DTOs;

public class CriacaoMusicaDTO
{
     [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }
    public TimeSpan Duracao { get; set; }
    public int? AlbumId { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "O artista é obrigatório.")]
    public int ArtistaId { get; set; }
}
