using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExercicioVerdadeiroFalsoController : ControllerBase
{
    [HttpGet("{tipo}")]
    public string Get(string tipo)
    {
        if(tipo == "verdadeiro" || tipo == "falso")
        {
            return " Texto diferente de verdadeiro ou falso";
        }
        return "O texto diferente de verdadeiro ou falso";
        throw new Exception("O texto diferente de verdadeiro ou falso");
    }
}