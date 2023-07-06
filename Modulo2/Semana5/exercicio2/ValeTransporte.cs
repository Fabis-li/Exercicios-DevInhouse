namespace exercicio2
{
    public class ValeTransporte : Cartao
    {
        public ValeTransporte()
        {            
        }

        public ValeTransporte(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
            
        }
         public override double VerificarValorTaxaCartao(double valorDaTaxa)
        {
           return saldo * 0.01;
        }
    }
}