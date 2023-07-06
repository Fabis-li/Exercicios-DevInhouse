using System.Text;

namespace modulo2_semana6_tests
{
    public class ExercicioSomaTest : ConfiguracaoHostApi
    {
        [Theory]
        [InlineData(4,2)]
        public async Task Soma_Teste_Sucesso(int a, int b)
        {
            var resultado = await client.GetAsync($"/ExercicioSoma/{a}/{b}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal($"{a} + {b} = {a + b}", responseApi);
        }   

        [Theory]
        [InlineData(51,6)]

        public async Task Soma_Teste_Erro(int a, int b)
        {
            var resultado = await client.GetAsync($"/ExercicioSoma/{a}/{b}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal($"{a + b}", responseApi);
        }
    }
}