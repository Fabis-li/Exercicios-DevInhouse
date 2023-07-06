namespace exercicio;

     public class Program
     {
          public static void Main(string[] args)
          {
               //Instância de todos os objetos, um de cada classe
               Empregado objetoEmpregado = new Empregado(1, "João");
               FuncionarioHorista objetoFuncionario = new FuncionarioHorista(2, "Marcelo", "12345", 0.1);
               SalarioEmpregado objetoSalarioEmpregado = new SalarioEmpregado(3, "Lucas", 3, 2.000);
               Secretaria objetoSecretaria = new Secretaria(4, "Mara", 4, 2.500, 10);

               //Impressões objeto classe Enmpregado
               Console.WriteLine($"Id do funcionário: {objetoEmpregado.id}");
               Console.WriteLine($"Nome do funcionário:{objetoEmpregado.nome}");
               //Todos os métodos Empregado
               objetoEmpregado.Trabalhar();
               objetoEmpregado.IrEmbora();
               objetoEmpregado.TirarFolga();
               Console.WriteLine("===========================");

               
              //Impressões objeto classe FuncionárioHorista
               Console.WriteLine($"Id do funcionário: {objetoFuncionario.id}");
               Console.WriteLine($"Nome do funcionário:{objetoFuncionario.nome}");
               Console.WriteLine($"CNPJ do funcionario: {objetoFuncionario.cnpj}");
               Console.WriteLine($"A taxa é:{objetoFuncionario.taxa}");
               //Todos os métodos FuncionárioHorista (incluindo os herdados)
               objetoFuncionario.Trabalhar();
               objetoFuncionario.IrEmbora();
               objetoFuncionario.TirarFolga();
               objetoFuncionario.CalcularTaxas();
               objetoFuncionario.EmitirNota();
               Console.WriteLine("============================");

               
               //Impressão objeto classe SalarioEmpregado
               Console.WriteLine($"Id do funcionário: {objetoSalarioEmpregado.id}");
               Console.WriteLine($"Nome do funcionário:{objetoSalarioEmpregado.nome}");
               Console.WriteLine($"Código do funcionario: {objetoSalarioEmpregado.codigoFuncionario}");
               Console.WriteLine($"O salário do funcionario: {objetoSalarioEmpregado.valorSalario}");
               //Todos os métodos SalarioEmpregado (incluindo os herdados)
               objetoSalarioEmpregado.Trabalhar();
               objetoSalarioEmpregado.IrEmbora();
               objetoSalarioEmpregado.TirarFolga();
               Console.WriteLine($"Calculo Folha de Pagamento: {objetoSalarioEmpregado.CalcularFolhaDePagamento(100)}");
               Console.WriteLine("==============================");

               
               //Impressão objeto classe Secretaria
               Console.WriteLine($"Id da secretária: {objetoSecretaria.id}");
               Console.WriteLine($"Nome da secretária:{objetoSecretaria.nome}");
               Console.WriteLine($"Nome da secretária:{objetoSecretaria.codigoFuncionario}");
               Console.WriteLine($"Nome da secretária:{objetoSecretaria.valorSalario}");
               Console.WriteLine($"Quantos anos tem de empresa: {objetoSecretaria.qtdeAnosEmpresa}");
               //Todos os métodos Secretaria (incluido os herdados)
               objetoSecretaria.Trabalhar();
               objetoSecretaria.IrEmbora();
               objetoSecretaria.TirarFolga();
               objetoSecretaria.CalcularFolhaDePagamento(100);
               objetoSecretaria.AtenderCliente();
               objetoSecretaria.RealizarLigacoes();
               Console.WriteLine("============================");
               
               


               
          }
     }

