using Microsoft.AspNetCore.Mvc;
using ApiMusicas.Repositores;
using ApiMusicas.Models;
using ApiMusicas.DTOs;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/artistas")]
    public class ArtistasController : ControllerBase
    {

        private readonly ArtistaRepository _artistaRepository;

        public ArtistasController(ArtistaRepository repository)
        {
            _artistaRepository = repository;
        }

        [HttpGet]
         public ActionResult<Artista> Get(
            [FromQuery] string filtro
            )
         {

            return Ok(_artistaRepository.ObterTodos(filtro));
         }

        [HttpPost]
        public ActionResult<Artista> Post(
            [FromBody] Artista novoArtista
        )
        {
            var artista = _artistaRepository.Criar(novoArtista);

            return Ok(artista);
        }

        [HttpPut("{idArtista}")]
        public ActionResult<Artista> AtualizarArtista(
            [FromBody] Artista artista,
            [FromRoute] int idArtista
        )
        {
            var artistaEditado = _artistaRepository.Atualizar(idArtista, artista);

            return Ok(artistaEditado);
        }

        [HttpPatch("{idArtista}/foto")]
        public ActionResult AtualizarFoto(
            [FromBody] ArtistaFotoDTO artistaFoto,
            [FromRoute] int idArtista
            )
        {
            var artista = _artistaRepository.AtualizarFoto(
                    idArtista,
                    artistaFoto.FotoUrl
            );

            return Ok(artista);
        }

        [HttpDelete("{idArtista}")]
        public ActionResult RemoverArtista(
            [FromRoute] int idArtista
        )
        {
            _artistaRepository.Remover(idArtista);

            return NoContent();
        }

        
    }
}