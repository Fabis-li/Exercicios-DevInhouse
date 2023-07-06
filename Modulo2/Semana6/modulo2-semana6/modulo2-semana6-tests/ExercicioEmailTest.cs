using System.Text;

namespace modulo2_semana6_tests
{
    public class ExercicioEmailTest : ConfiguracaoHostApi
    {
        [Theory]
        [InlineData("email@algo.com")]

        public async Task Teste_Api_Email_Sucesso (string email)
        {
            var resultado = await client.GetAsync($"/ExercicioEmail/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal(email, responseApi);
        }

        [Theory]
        [InlineData("teste@123")]

        public async Task Teste_Api_Email_Falho (string email)
        {
            var resultado = await client.GetAsync($"/ExercicioEmail/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();
            Assert.NotNull(responseApi);
            Assert.Equal(email, responseApi);
        }

    }
}