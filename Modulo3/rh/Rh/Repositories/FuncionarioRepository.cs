using Rh.DTOs;
using Rh.Enums;
using Rh.Models;

namespace Rh.Repositories
{
    public class FuncionarioRepository
    {
        public static List<FuncionarioModel> Funcionarios { get; set; } = new List<FuncionarioModel> {
            new FuncionarioModel(1, "Fabiano", "123", EPermissoes.Administrador, 7000M)           
        };

        public static List<FuncionarioModel> ObterTodos()
        {
            return Funcionarios;
        }

        public static FuncionarioModel? ObterPorUsuarioESenha(string nome, string senha)
        {
            var func = Funcionarios.FirstOrDefault(x => x.Nome == nome && x.Senha == senha);
            return func;
        }

        public static void Adicionar(FuncionarioDTO funcionario)
        {
            int novoId = GerarId();
            Funcionarios.Add(new FuncionarioModel(novoId, funcionario.Nome, funcionario.Senha, funcionario.Permissao, funcionario.Salario));
        }

        public static void Editar(FuncionarioDTO funcionario)
        {
            FuncionarioModel EditaFuncionario = ObterPorUsuarioESenha(funcionario.Nome, funcionario.Senha);
            funcionario.Nome = EditaFuncionario.Nome;
            funcionario.Senha = EditaFuncionario.Senha;
            funcionario.Permissao = EditaFuncionario.Permissao;
            funcionario.Salario = EditaFuncionario.Salario;
        }

        public static void Excluir(FuncionarioModel funcionario)
        {
            
             Funcionarios.Remove(funcionario);
        }

        private static int GerarId()
        {
            return Funcionarios.Last().Id + 1;
        }

        public static FuncionarioModel ObterPorId(int id)
        {
            return Funcionarios.FirstOrDefault(f => f.Id == id);    
        }

        
    }
}
