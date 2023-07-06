using System.Text;

namespace modulo2_semana6_tests
{
    public class ExercicioVerdadeiroFalsoTest : ConfiguracaoHostApi
    {
        [Theory]
        [InlineData("verdadeiro")]
        [InlineData("falso")]

        public async Task Teste_Api_Verdadeiro_Falso_Sucesso(string tipo)
        {
            var resultado = await client.GetAsync ($"/Exercício Verdadeiro ou Falso/ {tipo}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal(tipo, responseApi);
        }

        [Theory]
        [InlineData("Corinthians")]
        public async Task Teste_Api_Verdadeiro_Falso_Falha(string tipo)
        {
            var resultado = await client.GetAsync ($"/Exercício VErdadeiro ou Falso/ {tipo}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal(tipo, responseApi);
        }
    }
}

   