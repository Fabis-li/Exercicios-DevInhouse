using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]

public class ExercicioEmailController : ControllerBase
{
    [HttpGet("{email}")]
    public string Get(string email)
    {
        string regex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        Regex validacao = new (regex);

        if (DateTime.Now.Minute >= 30)
        {
            throw new MinutosException("Erro na requição passou mais de 30");
        }
        if(!validacao.IsMatch(email))
        {
            return "Email Invalido";
        }
        return email;
    }

    
    
}
[Serializable]
public class MinutosException : Exception
{
    public MinutosException(){}
    public MinutosException(string message) : base (message) {}
    public MinutosException(string message, Exception inner) :base (message, inner){}
    protected MinutosException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context){}
    
}

