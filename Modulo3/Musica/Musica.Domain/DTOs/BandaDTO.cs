namespace Musica.Domain.DTOs;

public class BandaDTO
{
    public string Descricao { get; set; }
    public string NomeMusica { get; set; }
    public int SequenciaMusica { get; set; } 

       public BandaDTO()
    {
       
    }

       public BandaDTO(string descricao, string nomeMusica, int sequenciaMusica)
    {
        Descricao = descricao;
        NomeMusica = nomeMusica;
        SequenciaMusica = sequenciaMusica;
    }
}
