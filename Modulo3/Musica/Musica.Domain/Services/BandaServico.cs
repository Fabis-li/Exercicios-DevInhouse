using Musica.Domain.DTOs;
using Musica.Domain.Interfaces.Repositories;
using Musica.Domain.Interfaces.Services;

namespace Musica.Domain.Services;


public class BandaServico : IBandaServico
{
    private readonly IBandaRepository _bandaRepository;
    public BandaServico (IBandaRepository bandaRepository)
    {
        _bandaRepository = bandaRepository;
    }

    public void CadastraBandaTocar(BandaDTO bandadto)
    {
        throw new NotImplementedException();
    }
}
