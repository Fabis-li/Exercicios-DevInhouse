using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExercicioSomaController : ControllerBase
{
    [HttpGet("{valorA}/{valorB}")]
    public string Get(int valorA, int valorB)
    {
        try
        {
            int soma = valorA + valorB;
            if (soma < 10)
            {
                return $"{soma}";
            }
            Random numero = new Random();
            return $"{numero.Next(10, 9999)}";
        }
        catch (Exception ex)
        {
            
            throw new Exception("Erro ao somar.", ex);
        }
    }
}
