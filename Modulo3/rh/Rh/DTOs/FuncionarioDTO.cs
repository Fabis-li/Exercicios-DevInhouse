using Rh.Enums;
using Rh.Models;

namespace Rh.DTOs
{
    public class FuncionarioDTO
    {  

        public string Nome { get; set; }
        public string Senha { get; set; }
        public EPermissoes Permissao { get; set; }
        public decimal Salario { get; set; }

        public FuncionarioDTO()
        {
            
        }

        public FuncionarioDTO(string nome, string senha, EPermissoes permissao, decimal salario)
        {
            Nome = nome;
            Senha = senha;
            Permissao = permissao;
            Salario = salario;
        }

        

    }
}
