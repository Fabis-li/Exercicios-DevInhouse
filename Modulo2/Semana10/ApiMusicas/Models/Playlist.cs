using System.ComponentModel.DataAnnotations;

namespace ApiMusicas.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome da Playlist é obrigatório.")]
        public string Nome { get; set; }
        public string Estilo { get; set; }

        public List<Musica> Musicas { get; set; } = new();

        public Playlist(string nome, string estilo)
        {
            Nome = nome;
            Estilo = estilo;    
        }

        public void AdicvionarMusicas(Musica musicas)
        {
            Musicas = new List<Musica>();

            Musicas.Add(musicas);   
        }

        public void RemoverMusicas(int idMusica)
        {
            var musicaAtual = Musicas.FirstOrDefault(m => m.Id == idMusica);
            Musicas.Remove(musicaAtual);
        }
    }
}
