using Microsoft.AspNetCore.Mvc;
using Rh.DTOs;
using Rh.Models;
using Rh.Repositories;
using Rh.Services;

namespace Rh.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        [HttpPost]
        [Route("login")]

        public IActionResult Login(
            [FromBody] LoginFuncionarioDTO login
        )
        {
            var func = FuncionarioRepository.ObterPorUsuarioESenha(login.Nome, login.Senha);

            if (func == null)
                return Unauthorized();

            var token = TokenService.GenerateToken(func);

            return Ok(token);
        }
    }
}
