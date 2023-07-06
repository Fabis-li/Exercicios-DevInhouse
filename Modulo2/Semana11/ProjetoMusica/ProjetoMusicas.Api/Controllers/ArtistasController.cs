using Microsoft.AspNetCore.Mvc;
using ProjetoMusicas.Api.Data;
using ProjetoMusicas.Api.DTOs;
using ProjetoMusicas.Api.Models;
using ProjetoMusicas.Api.ViewModels;

namespace ProjetoMusicas.Api.Controllers;

[ApiController]
[Route("api/artistas")]
public class ArtistasController : ControllerBase
{
    private readonly ProjetoDbContext _context;

    public ArtistasController(ProjetoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Artista>> Get()
    {
        return Ok(_context.Artistas.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Artista> GetPorId(
        [FromRoute] int id
    ){
        var artista = _context.Artistas.Find(id);

        if(artista == null) return NotFound();

        return Ok(artista);
    }

    [HttpPost]
    public ActionResult<Artista> Post(
        [FromBody] ArtistaDTO artistaDTO
    ){
        if(_context.Artistas.Any(a => a.Nome == artistaDTO.Nome)){
            return BadRequest(new RetornoComFalhaViewModel("Já existe um artista com esse nome"));
        }

        var artista = new Artista{
            Nome = artistaDTO.Nome,
            NomeArtistico = artistaDTO.NomeArtistico,
            FotoUrl = artistaDTO.FotoUrl
        };

        _context.Artistas.Add(artista);

        _context.SaveChanges();

        return Created("api/artistas", artista);
    }

    [HttpPut("{id}")]
    public ActionResult<Artista> Put(
        [FromRoute] int id,
        [FromBody] ArtistaDTO artistaDTO
    ){
        var artista =  _context.Artistas.Find(id);

        if(artista == null) return NotFound(new RetornoComFalhaViewModel("Artista não encontrado"));

        artista.Nome = artistaDTO.Nome;
        artista.NomeArtistico = artistaDTO.NomeArtistico;
        artista.FotoUrl = artistaDTO.FotoUrl;

        _context.SaveChanges();

        return Ok(artista);
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(
        [FromRoute] int id
    ){
        var artista =  _context.Artistas.Find(id);

        if(artista == null) return NotFound(new RetornoComFalhaViewModel("Artista não encontrado"));

        _context.Artistas.Remove(artista);

        _context.SaveChanges();

        //204
        return NoContent();
    }

    [HttpPost("{id}/album")]
    public ActionResult<Album> PostAlbum(
        [FromRoute] int id,
        [FromBody] AlbumDTO albumDTO
    ){
        var artista = _context.Artistas.Find(id);

        if(artista == null)
            return NotFound(new RetornoComFalhaViewModel("Artista não encontrado."));
        
        var album = new Album{
            Nome = albumDTO.Nome,
            CapaUrl = albumDTO.CapaUrl,
            AnoLancamento = albumDTO.AnoLancamento,
            ArtistaId = artista.Id,
            Musicas = albumDTO.Musicas?.Select(musicaDTO => new Musica{
                Nome = musicaDTO.Nome,
                Duracao = musicaDTO.Duracao,
                ArtistaId = artista.Id
            }).ToList()
        };

        _context.Albuns.Add(album);
        _context.SaveChanges();

        var viewModel = new AlbumComMusicasViewModel(album);

        return Created($"api/artista/{id}/album", viewModel);
    }
}
