namespace Musica.Domain.Models;

public class BandaModel
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public string NomeMusica { get; set; }
    public int SequenciaMusica { get; set; }

      public BandaModel()
    {
        
    }

      public BandaModel(int id, string descricao, string nomeMusica, int sequenciaMusica)
    {
        Id = id;
        Descricao = descricao;
        NomeMusica = nomeMusica;
        SequenciaMusica = sequenciaMusica;
    }
}
