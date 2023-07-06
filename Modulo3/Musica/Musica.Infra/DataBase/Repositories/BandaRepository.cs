using Musica.Domain.Interfaces.Repositories;
using Musica.Domain.Models;

namespace Musica.Infra.DataBase.Repositories;

public class BandaRepository : IBandaRepository
{
    private readonly BandaDbContext _context;
    public BandaRepository(BandaDbContext context)
    {
        _context = context;
    }

    public void CadastraBandaTocar(BandaModel banda)
    {
        throw new NotImplementedException();
    }
}
