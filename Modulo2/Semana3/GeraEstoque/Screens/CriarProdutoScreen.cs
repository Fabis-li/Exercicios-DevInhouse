using GeraEstoque.Models;
using GeraEstoque.Repositories;
using System.Globalization;

namespace GeraEstoque.Screens
{
    public static class CriarProdutoScreen
    {
        public static void Iniciar(ProdutoRepository repository)
        {
            
            Guid Id = Guid.NewGuid();
            string nome = "";        
            int qtdeEmEstoque = 0;
            decimal valorDeCompra = 0m;
            decimal valorDeVenda = 0m; 
            

            Console.Clear();
            Console.WriteLine("1 Cadastro de Produto");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine($"ID {Id}");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Qtde em estoque: ");
            qtdeEmEstoque = int.Parse(Console.ReadLine());
            Console.Write("Valor de Compra:R$ ");        
            valorDeCompra = Decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            Console.Write("Valor de venda:R$ ");        
            valorDeVenda = Decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            //NumberStyles e CultureInfo - formatar o numero 

            repository.ListaDeProdutos.Add(new Produto(nome, qtdeEmEstoque,valorDeCompra, valorDeVenda));
            ShowProduto(repository,  nome, qtdeEmEstoque, valorDeCompra, valorDeVenda);

        } 

        public static void ShowProduto(ProdutoRepository repository,  string nome,int qtdeEmEstoque, decimal valorDeCompra, decimal valorDeVenda)
        {
            Console.Clear();
            Console.WriteLine("Produto Cadastrado com sucesso!");
            Console.WriteLine();
            // Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Estoque: {qtdeEmEstoque}");
            Console.WriteLine($"R$ Compra:R$ {valorDeCompra.ToString("c")}");
            Console.WriteLine($"R$ Venda:R$ {valorDeVenda.ToString("c")}");
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para retornar ao menu");

            //voltar para o menu inicial
            var back = Console.ReadKey();
            switch(back)
            {
                default: MenuScreen.Iniciar(repository); break;
            }
        }       
            
        
        
    }
}