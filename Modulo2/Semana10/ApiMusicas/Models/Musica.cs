namespace ApiMusicas.Models
{
    public class Musica
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public TimeSpan  Duracao { get; set; }

        public Album Album { get; set; }

        public Artista Artista { get; set; }

        public Playlist Playlist { get; set; }

        public Musica(string nome, TimeSpan duracao, Artista artista)
        {
            Nome = nome;
            Duracao = duracao;
            Artista = artista;
        }
    }

 
    
}
