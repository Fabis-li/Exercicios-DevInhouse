using System;

namespace exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cartao objetoCartao = new Cartao("visa", 1000.00, 0.02);
            
            //Upcasting
            Cartao objetoCartaoVA = new ValeAlimentacao("va", 400.00, 0.05);
            Cartao objetoCartaoVR = new ValeRefeicao("vr", 500.00, 0.07);
            Cartao objetoCartaoVT = new ValeTransporte ("vt", 400.00, 0.01);

            //Objeto Cartao
            Console.WriteLine($"Cartão - Bandeira: {objetoCartao.bandeira}");
            Console.WriteLine($"Cartão - Saldo: {objetoCartao.saldo}");
            Console.WriteLine($"Cartão - Valor da Taxa: {objetoCartao.valorTaxa}");
            Console.WriteLine($"Cartão - Valor referente a taxa: {objetoCartao.VerificarValorTaxaCartao(objetoCartao.saldo)}");
            
            //Objeto ValeAlimentação
            Console.WriteLine($"Vale Alimentação - Bandeira: {objetoCartaoVA.bandeira}");
            Console.WriteLine($"Vale Alimentação - Saldo: {objetoCartaoVA.saldo}");
            Console.WriteLine($"Vale Alimentação - Valor da Taxa: {objetoCartaoVA.valorTaxa}");
            Console.WriteLine($"Vale Alimentação - Valor referente a taxa: {objetoCartaoVA.VerificarValorTaxaCartao(objetoCartaoVA.saldo)}");


            //Obejto ValeRefeição
            Console.WriteLine($"Vale Refeição - Bandeira: {objetoCartaoVR.bandeira}");
            Console.WriteLine($"Vale Refeição - Saldo: {objetoCartaoVR.saldo}");
            Console.WriteLine($"Vale Refeição - Valor da Taxa: {objetoCartaoVR.valorTaxa}");
            Console.WriteLine($"Vale Refeição - Valor referente a taxa: {objetoCartaoVR.VerificarValorTaxaCartao(objetoCartaoVR.saldo)}");


            //Objeto ValeTransporte
            Console.WriteLine($"Vale Transporte - Bandeira: {objetoCartaoVT.bandeira}");
            Console.WriteLine($"Vale Transporte - Saldo: {objetoCartaoVT.saldo}");
            Console.WriteLine($"Vale Transporte - Valor da Taxa: {objetoCartaoVT.valorTaxa}");
            Console.WriteLine($"Vale Transporte - Valor referente a taxa: {objetoCartaoVT.VerificarValorTaxaCartao(objetoCartaoVT.saldo)}");


            // Downcasting
            ValeAlimentacao objetoCartaoVADowncasting = new ValeAlimentacao();
            objetoCartaoVADowncasting = (ValeAlimentacao)objetoCartaoVA;

            ValeRefeicao objetoCartaoVRDowncasting = new ValeRefeicao();
            objetoCartaoVRDowncasting = (ValeRefeicao)objetoCartaoVR;

            ValeTransporte objetoCartaoVTDowncasting = new ValeTransporte();
            objetoCartaoVTDowncasting = (ValeTransporte)objetoCartaoVT;
        }


    }
}
