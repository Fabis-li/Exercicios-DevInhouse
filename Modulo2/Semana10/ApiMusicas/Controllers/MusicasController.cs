using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/musicas")]
    public class MusicasController : ControllerBase
    {
        private readonly ArtistaRepository _artistaRepository;
        private readonly AlbumRepository _albumRepository;
        private readonly MusicaRepository _musicaRepository;
        private readonly PlaylistRepository _playlistRepository;


        public MusicasController(
            MusicaRepository musicaRepository, 
            AlbumRepository albumRepository, 
            ArtistaRepository artistaRepository,
            PlaylistRepository playlistRepository
            )
        {
            _musicaRepository = musicaRepository;
            _artistaRepository = artistaRepository;
            _albumRepository = albumRepository;
            _playlistRepository = playlistRepository;
        }

        [HttpGet]

        public List<Musica> Get(
            [FromQuery] string? nomeMusica,
            [FromQuery] string? nomeArtista,
            [FromQuery] string? nomeAlbum
        )
        {
            if (nomeMusica != null || nomeArtista != null || nomeAlbum != null)
            {
                return _musicaRepository.ObterPorPesquisa(nomeMusica, nomeArtista, nomeAlbum);
            }
            return _musicaRepository.ObterTodos();
        }

        [HttpGet("{idMusica}")]

        public Musica GetById(
            [FromRoute] int IdMusica   
        )
        {
            return _musicaRepository.ObterPorId(IdMusica);
        }

        [HttpPost]
        public ActionResult<Musica> Post(
            [FromBody] MusicaDTO body    
        )
        {
            var playlist = _playlistRepository.ObterPorId(body.PlaylistId);
            var artista = _artistaRepository.ObterPorId(body.ArtistaId);
            var album = _albumRepository.ObterPorId(body.AlbumId);
            var musica = new Musica(
                body.Nome,
                body.Duracao,
                artista
            );
            musica.Album = album;
            musica.Playlist = playlist;
            _musicaRepository.Criar(musica);

            return Ok(musica);            
        }

        [HttpPut("{idMusica}")]
        public ActionResult<Musica> Put(
            [FromBody] Musica body,
            [FromRoute] int idMusica
        )
        {
            var musica = _musicaRepository.ObterPorId(idMusica);

            musica.Nome = body.Nome;
            musica.Artista = body.Artista;
            musica.Duracao = body.Duracao;

            _musicaRepository.Atualizar(idMusica, musica);

            return Ok(musica);
        }

        [HttpDelete("{idMusica}")]
        public ActionResult Delete(
         int idMusica
        )
        {
            _musicaRepository.Remover(idMusica);

            return NoContent();
        }


    }
}
