using Rh.Enums;

namespace Rh.ViewModels
{
    public class ListaFuncionarioViewModel
    {
       

        public string Nome { get; set; }
        public EPermissoes Permissaso { get; set; }

         public ListaFuncionarioViewModel(string nome, EPermissoes permissaso)
        {
            Nome = nome;
            Permissaso = permissaso;
        }

    }
}