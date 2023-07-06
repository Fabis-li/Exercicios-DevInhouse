using System.Text.RegularExpressions;

namespace exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario objetofuncionario = new Funcionario("1", "Mario");
            
            try
            {
                ValidacaoNomeFuncionario(objetofuncionario);
                ValidacaoIdFuncionario(objetofuncionario);
                VerificaoObjetoFuncionarioNull(objetofuncionario);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. Messagem: {ex.Message}");
            }
            
        }

        public static void VerificaoObjetoFuncionarioNull(Funcionario objetofuncionario)
        {
            if(objetofuncionario == null)
            {
                throw new NullReferenceException("\nO objeto Funcionário é nulo. Informe os valores.\n");
            }
            Console.WriteLine(
                $"\n O nome do funcionário é {objetofuncionario.id}" + 
                $"\n O código do funcionário é {objetofuncionario.nome}"
            );
        }
        public static void ValidacaoNomeFuncionario(Funcionario objetofuncionario)
        {
            Regex regexLetras = new Regex("^[a-zA-Z]+$");            

            if(!regexLetras.IsMatch(objetofuncionario.nome))
            {
                throw new NomeFuncionarioInvalidoException(objetofuncionario.nome);
            }            
        }
        public static void ValidacaoIdFuncionario(Funcionario objetofuncionario)
        {
            Regex regexNumeros = new Regex("^[0-9]+$");

            if(!regexNumeros.IsMatch(objetofuncionario.id))
            {
                throw new IdFuncionarioInvalidoException(objetofuncionario.id);
            }
        }
    }
}
