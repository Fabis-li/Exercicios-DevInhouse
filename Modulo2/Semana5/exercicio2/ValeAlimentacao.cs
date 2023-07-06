namespace exercicio2
{
    public class ValeAlimentacao : Cartao
    {
        public ValeAlimentacao()
        {            
        }

        public ValeAlimentacao(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {            
        }
        public override double VerificarValorTaxaCartao(double valorDaTaxa)
        {
           return saldo * 0.05;

        }
    }   

    
}