using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/albuns")]
    public class AlbunsController : ControllerBase
    {
        private readonly AlbumRepository _albumRepository;

        private readonly ArtistaRepository _artistaRepository;

        private readonly MusicaRepository _musicaRepository;

        public AlbunsController(AlbumRepository albumRepository, ArtistaRepository artistaRepository, MusicaRepository musicaRepository)
        {
            _albumRepository = albumRepository;
            _artistaRepository = artistaRepository;
            _musicaRepository = musicaRepository;
        }

        [HttpGet()]
        public ActionResult<Album> GetMusicasPorIdAlbum()
        {
            return Ok(_albumRepository.ObterTodos());
        }

        [HttpGet("{idAlbum}/musicas")]
        public ActionResult<Musica> Get(
            [FromRoute] int idAlbum
         )
        {
            return Ok(_musicaRepository.ObterPorAlbum(idAlbum));
        }

        [HttpPost]
        public ActionResult<Album> Post(
            [FromBody] AlbumDTO albumJson
            )
        {
            var artista = _artistaRepository.ObterPorId(albumJson.ArtistaId);

            var album = new Album(
                albumJson.Nome,
                albumJson.AnoLancamento,
                albumJson.CapaUrl,
                artista

            );

            _albumRepository.Criar(album);

            return Ok(album);

        }

        [HttpPut("{idAlbum}")]
        public ActionResult<Album> Put(
            [FromBody] AlbumDTO albumJson,
            [FromRoute] int idAlbum
         )
        {
            var artista = _artistaRepository.ObterPorId(albumJson.ArtistaId);

            var album = _albumRepository.ObterPorId(idAlbum);

            _albumRepository.Atualizar(
                idAlbum,
                new Album(
                    albumJson.Nome,
                    albumJson.AnoLancamento,
                    albumJson.CapaUrl,
                    artista
                    )
             );

            return Ok(album);

        }

        [HttpDelete("{idAlbum}")]
        public ActionResult Delete(
            int idAlbum   
         )
        {
            _albumRepository.Remover(idAlbum);

            return NoContent();
        }


    }
}
