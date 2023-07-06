using GeraEstoque.Repositories;
using GeraEstoque.Models;
using GeraEstoque.Screens;  


namespace GeraEstoque // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ProdutoRepository repository = new ProdutoRepository();

          MenuScreen.Iniciar(repository);
        }
    }
}
