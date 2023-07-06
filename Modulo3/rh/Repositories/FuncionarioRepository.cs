using rh.DTOs;
using rh.Enums;
using rh.Models;

namespace rh.Repositories
{
    public static class FuncionarioRepository
    {
        public static List<FuncionarioModel> Funcionarios {get; set;} = new List<FuncionarioModel> {
            new FuncionarioModel(1,"Fabiano", "admin", EPermissoes.Administrador, 0M)
        };

        public static List<FuncionarioModel> Obter()
        {
            return Funcionarios;
        }

        public static FuncionarioModel ObterPorUsuarioESenha(string nome, string senha)
        {
           return Funcionarios.FirstOrDefault(f => f.Nome == nome && f.Senha == senha);
        }
        
        public static void Adicionar(FuncionarioDTO funcionario)
        {
            int id = GeraId();
            Funcionarios.Add(new FuncionarioModel(id, 
                                        funcionario.Nome, 
                                        funcionario.Senha, 
                                        funcionario.Permisao, 
                                        funcionario.Salario
                                        ));            
        }

        private static int GeraId()
        {
            return Funcionarios.Last().Id + 1;
        }

        public static void Editar(FuncionarioDTO funcionario)
        {
            FuncionarioModel atualizaFuncionario = ObterPorUsuarioESenha(funcionario.Nome, funcionario.Senha);
            atualizaFuncionario.Nome = funcionario.Nome;
            atualizaFuncionario.Senha = funcionario.Senha;
            atualizaFuncionario.Permisao = funcionario.Permisao;
            atualizaFuncionario.Salario = funcionario.Salario;            
        }
        public static void Excluir(int id)
        {
            var idFuncionario = Funcionarios.FirstOrDefault(x => x.Id == id);
            if(idFuncionario != null)
                Funcionarios.Remove(idFuncionario);
        }
    }
    
}