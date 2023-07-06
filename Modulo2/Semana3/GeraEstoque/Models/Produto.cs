namespace GeraEstoque.Models
{
    public class Produto
    {
       public string Id;

       public string Nome;

       public int QtdeEmEstoque;

       public decimal ValorDeCompra;

       public decimal ValorDeVenda;

        public Produto(string nome, int qtdeEmEstoque, decimal valorDeCompra, decimal valorDeVenda)
        {
            Id = Guid.NewGuid().ToString().Substring(0,4);
            Nome = nome;
            QtdeEmEstoque = qtdeEmEstoque;
            ValorDeCompra = valorDeCompra;
            ValorDeVenda = valorDeVenda;
        }

       public override string ToString()
       {
        return $"Produto Id: {Id} | Nome: {Nome} | Qtde: {QtdeEmEstoque} | R$ Compra: {ValorDeCompra.ToString("c")} | R$ Venda: {ValorDeVenda.ToString("c")}";

       }
        
    }

// Produto: Id: XXXX |  Nome: XXX | Qtd: XXX | R$ Compra: XXX | R$ Venda: XXX
}