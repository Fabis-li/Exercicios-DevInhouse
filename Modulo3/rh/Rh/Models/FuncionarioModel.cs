using Rh.DTOs;
using Rh.Enums;

namespace Rh.Models
{
    public class FuncionarioModel
    {  

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public EPermissoes Permissao { get; set; }
        public decimal Salario { get; set; }

        public FuncionarioModel() { }          
        


        public FuncionarioModel(int id, string nome, string senha, EPermissoes permissao, decimal salario)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Permissao = permissao;
            Salario = salario;
        }

        
    }
}
