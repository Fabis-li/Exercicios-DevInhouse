using rh.Enums;

namespace rh.DTOs
{
    public class FuncionarioDTO
    {

        public string Nome { get; set; }
        public string Senha { get; set; }
        public EPermissoes Permisao { get; set; }
        public decimal Salario{ get; set; }

        public FuncionarioDTO(string nome, string senha, EPermissoes permisao, decimal salario)
        {
           
            Nome = nome;
            Senha = senha;
            Permisao = permisao;
            Salario = salario;
        }

        
    }
}