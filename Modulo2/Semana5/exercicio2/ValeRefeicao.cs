namespace exercicio2
{
    public class ValeRefeicao : Cartao
    {
        public ValeRefeicao()
        {            
        }

        public ValeRefeicao(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
            
        }
         public override double VerificarValorTaxaCartao(double valorDaTaxa)
        {
           return saldo * 0.07;
        }
    }
}