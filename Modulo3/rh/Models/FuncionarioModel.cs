using rh.Enums;

namespace rh.Models
{
    public class FuncionarioModel
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public EPermissoes Permisao { get; set; }
        public decimal Salario{ get; set; }

        public FuncionarioModel()
        {
            
        }

        public FuncionarioModel(int id, string nome, string senha, EPermissoes permisao, decimal salario)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Permisao = permisao;
            Salario = salario;
        }
    }
}