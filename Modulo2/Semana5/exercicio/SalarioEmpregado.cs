namespace exercicio
{
    public class SalarioEmpregado : Empregado
    {  
        public int codigoFuncionario { get; set; }
        public double valorSalario { get; set; }

        public SalarioEmpregado()
        {            
        }

        public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario) : base(id, nome)
        {
            this.codigoFuncionario = codigoFuncionario;
            this.valorSalario = valorSalario;
        }

        public double CalcularFolhaDePagamento(double valorSalario )
        {
            return valorSalario;
        }
    }
}