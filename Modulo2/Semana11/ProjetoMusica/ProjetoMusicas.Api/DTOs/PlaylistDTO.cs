using System.ComponentModel.DataAnnotations;

namespace ProjetoMusicas.Api.DTOs;

public class PlaylistDTO
{
     [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }
}
