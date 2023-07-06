using System.ComponentModel.DataAnnotations;

namespace ApiMusicas.DTOs
{
    public class PlaylistDTO
    {
        [Required(ErrorMessage = "Nome da Paylist é obrigatório.")]
        public string Nome { get; set; }
        public string Estilo { get; set; }

        [Required(ErrorMessage = "O id da Playlist é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O id da Playlist precisa ser válido!")]
        public int IdPlaylist { get; set; }
        [Required(ErrorMessage = "O id da música é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O id da música precisa ser válido!")]
        public int MusicaId { get; set; }
    }
}
