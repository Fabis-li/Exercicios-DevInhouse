namespace exercicio
{
    public class FuncionarioHorista : Empregado
    {
        public string cnpj { get; set; }
        public double taxa { get; set; }

        public FuncionarioHorista()
        {            
        }

        public FuncionarioHorista(int id, string nome,string cnpj, double taxa) :base(id, nome)
        {
            this.cnpj = cnpj;
            this.taxa = taxa;
        }

        public void CalcularTaxas()
        {
            Console.WriteLine("Calculando Imposto");
        }

        public void EmitirNota()
        {
            Console.WriteLine("Emitindo Nota");
        }
    }
    
}