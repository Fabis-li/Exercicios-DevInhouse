using System;
using Eng_Uber;

namespace Test.Nunit;


public class Tests
{
    [Test]
    public void VerificaOrigemDestinoCorrida()
    {
       var caminho = new Corrida();

       Assert.Catch(()=>{
            caminho.Solicitar();
        
       });

       caminho.Origem = new Endereco{
            Rua = "Dois",
            Numero = 70
       };
       caminho.Destino = new Endereco{
            Rua = "Vinte e sete",
            Numero = 50
       };

       Assert.DoesNotThrow(() => {
            caminho.Solicitar();
       });
    }
}

