using Musica.Domain.Models;

namespace Musica.Domain.Interfaces.Repositories;

public interface IBandaRepository
{
    public void CadastraBandaTocar(BandaModel banda);

}
