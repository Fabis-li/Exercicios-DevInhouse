namespace exercicio
{
    public class Secretaria : SalarioEmpregado
    {
        public int qtdeAnosEmpresa { get; set; }

        public Secretaria()
        {            
        }

        public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdeAnosEmpresa)
            : base(id, nome, codigoFuncionario, valorSalario)
            
        {
            this.qtdeAnosEmpresa = qtdeAnosEmpresa;
        }

        public void AtenderCliente()
        {
            Console.WriteLine("Atendendo Cliente");
        }

        public void RealizarLigacoes()
        {
            Console.WriteLine("Ligando....Alô");
        }
    }
}