using ApiMusicas.Models;

namespace ApiMusicas.Repositores
{
    public class MusicaRepository
    {
        private static int _indiceId = 1;

        private static List<Musica> _musicas = new();
        public Musica Criar(Musica musica)
        {
            musica.Id = _indiceId;

            _indiceId++;

            _musicas.Add(musica);

            return musica;
        }

        public Musica Atualizar(int id, Musica musica)
        {
            var musicaExistente = _musicas
                .FirstOrDefault(musicaLista => musicaLista.Id == musica.Id);

            if (musicaExistente == null) return null;

            musicaExistente.Nome = musica.Nome;
            musicaExistente.Duracao = musica.Duracao; 
            musicaExistente.Artista = musica.Artista;
            musicaExistente.Album = musica.Album;



            return musicaExistente;
        }

        public void Remover(int musicaId)
        {
            var musicaExistente = _musicas.FirstOrDefault(musicaLista => musicaLista.Id == musicaId);

            _musicas.Remove(musicaExistente);

        }

        public List<Musica> ObterTodos()
        {
            return _musicas;
        }

        public List<Musica> ObterPorAlbum(int idAlbum)
        {
            return _musicas
                .Where(m => m.Album != null)
                .Where(m => m.Album.Id == idAlbum)
                .ToList();
        }

        public List<Musica> ObterPorPesquisa(string nome, string artista, string album)
        {
            var listaMusicas = _musicas
                .Where(m => m.Nome == nome || m.Artista.Nome == artista || m.Album?.Nome == album).ToList();
            return listaMusicas;
        }

        public Musica ObterPorId(int musicaId)
        {
            return _musicas.FirstOrDefault(a => a.Id == musicaId);
        }

    }
}
