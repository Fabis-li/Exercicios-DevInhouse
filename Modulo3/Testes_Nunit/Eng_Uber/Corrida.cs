namespace Eng_Uber;

public class Corrida
{
    public Endereco Origem { get; set; }
    public Endereco Destino { get; set; }

    public void Solicitar()
    {
        if(Origem == null || Destino == null)
            throw new Exception("Os campos devem ser preenchidos.");
    }
}