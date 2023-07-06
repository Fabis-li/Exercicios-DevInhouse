using ApiMusicas.Models;

namespace ApiMusicas.Repositores
{
    public class PlaylistRepository
    {
        private static int _idIndice = 1;

        private static List<Playlist> _playlist = new();

        public Playlist AdicionarPlaylist(Playlist playlist)
        {
            playlist.Id = _idIndice;
            _idIndice++;
            
            _playlist.Add(playlist);

            return playlist;
        }

        public List<Playlist> ObterTodos()
        {
            return _playlist;
        }

        public Playlist ObterPorId(int id)
        {
            var playlist = _playlist.FirstOrDefault(p => p.Id == id);

            if (playlist == null)
                return null;

            return playlist;
            
        }

        public Playlist Atualizar(Playlist playlist)
        {
            var playlistAtual = ObterPorId(playlist.Id);

            playlistAtual.Nome = playlist.Nome;

            return playlistAtual;
        }

        public void Remover(int id)
        {
            var playlistExistente = _playlist.FirstOrDefault(p => p.Id == id);

            _playlist.Remove(playlistExistente);
        }

        public Playlist AdicionarMusicaNaPlaylist(Playlist playlist, Musica musica)
        {
            var playlistAtual = ObterPorId(playlist.Id);

            playlistAtual.AdicvionarMusicas(musica);

            return playlistAtual;
        }

        public Playlist RemoverMusicaDaPlaylist(Playlist playlist, int idMusica)
        {
            var playlistAtual = ObterPorId(playlist.Id);

            playlistAtual.RemoverMusicas(idMusica);

            return playlistAtual;
        }

    }
}
