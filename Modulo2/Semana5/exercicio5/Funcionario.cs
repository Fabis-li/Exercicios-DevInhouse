namespace exercicio5
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string id { get; set; }

        public Funcionario()
        {            
        }

        public Funcionario(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }

        
    }

    [Serializable]
    class NomeFuncionarioInvalidoException : Exception
    {
        public NomeFuncionarioInvalidoException(){}

        public NomeFuncionarioInvalidoException(string nome) 
            : base(String.Format($"\nO nome do funcionário foi digitado com caracteres inválidos: {nome}.\n"))
        {

        }
    }

    [Serializable]
    class IdFuncionarioInvalidoException : Exception
    {
        public IdFuncionarioInvalidoException(){}
        public IdFuncionarioInvalidoException(string id)
            : base(String.Format($"\nO id informado do funcionário foi digitado com caracteres inválidos: {id}\nSão permitidos apenas números no Id/código."))
            {

            }
    }
}