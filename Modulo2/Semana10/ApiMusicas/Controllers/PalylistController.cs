using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    public class PalylistController
    {
        [ApiController]
        [Route("api/playlist")]
        public class PlaylistController : ControllerBase
        {
            private readonly PlaylistRepository _playlistRepository;
            private readonly MusicaRepository _musicaRepository;

            public PlaylistController(
                PlaylistRepository playlistRepository,
                MusicaRepository musicaRepository)
            {
                _playlistRepository = playlistRepository;
                _musicaRepository = musicaRepository;
            }

            [HttpGet]
            public ActionResult<Playlist> Get()
            {
                return Ok(_playlistRepository.ObterTodos());
            }

            [HttpPost]
            public ActionResult<Playlist> Post(
                [FromBody] PlaylistDTO novaLista)
            {
                var playlist = new Playlist(
                    novaLista.Nome,
                    novaLista.Estilo);

                _playlistRepository.AdicionarPlaylist(playlist);

                return Ok(playlist);
            }

            [HttpPost("AddMusicas")]
            public ActionResult<Playlist> PostAddMusica(
                [FromBody] PlaylistDTO body)
            {
                var playlist = _playlistRepository.ObterPorId(body.IdPlaylist);
                var musica = _musicaRepository.ObterPorId(body.MusicaId);

                _playlistRepository.AdicionarMusicaNaPlaylist(playlist, musica);

                return Ok(playlist);
            }

            [HttpPut("{idPlaylist}")]
            public Playlist Put(
                [FromBody] PlaylistDTO body,
                [FromRoute] int idPlaylist
            )
            {
                var playlist = _playlistRepository.ObterPorId(idPlaylist);

                playlist.Nome = body.Nome;
                playlist.Estilo = body.Estilo;

                _playlistRepository.Atualizar(playlist);
                return playlist;
            }

            [HttpDelete("{idPlaylist}")]
            public ActionResult Delete(
                int idPlaylist
            )
            {
                _playlistRepository.Remover(idPlaylist);

                return NoContent();
            }

            [HttpDelete("{idPlaylist}/{idMusica}")]
            public Playlist DeleteMusica(
                [FromRoute] int idPlaylist,
                [FromRoute] int idMusica
            )
            {
                var playlist = _playlistRepository.ObterPorId(idPlaylist);
                return _playlistRepository.RemoverMusicaDaPlaylist(playlist, idMusica);
            }
        }
    }
}
