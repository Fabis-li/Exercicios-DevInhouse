using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rh.DTOs;
using rh.Repositories;

namespace rh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrar")]
        [Authorize(Roles = "Gerente,Administrador")]
        public IActionResult Cadastrar(
            [FromBody]FuncionarioDTO funcionario
        )
        {
            FuncionarioRepository.Adicionar(funcionario);
            return Ok();
            return Created("api/funcionario", funcionario);
        }
        

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles="Gerente, Administrador")]
        public IActionResult ExcluirFuncionario(
            [FromRoute] int id
        )
        {
            FuncionarioRepository.Excluir(id);
            return Ok();
        }
    }

}