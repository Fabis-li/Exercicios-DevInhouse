using Microsoft.AspNetCore.Mvc;
using Rh.DTOs;
using Rh.Models;
using Rh.Repositories;

namespace Rh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet("listar")]
        public ActionResult<List<FuncionarioModel>> Listar()
        {
            return FuncionarioRepository.ObterTodos();
        }

        [HttpPost("cadastrar-funcionario")]
        public IActionResult Cadastrar(
           [FromBody] FuncionarioDTO funcionario
        )
        {
            FuncionarioRepository.Adicionar(funcionario);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("excluir-funcionario/{id}")]
        public IActionResult ExcluirFuncionario(
            [FromRoute] int id
        )
        {
            return this.Excluir(id);
        }

        [HttpDelete("excluir-gerente/{id}")]
        public IActionResult ExcluirGerente(
            [FromRoute] int id
        )
        {
            return this.Excluir(id);
        }

        [HttpPut("alterar-salario/{id}")]
        public IActionResult AlterarSalario(
            [FromBody] FuncionarioDTO funcionario,
            [FromRoute] int id
        )
        {
            FuncionarioModel funcionarioSalario = FuncionarioRepository.ObterPorId(id);
            if (funcionarioSalario != null) {
                FuncionarioRepository.Editar(new FuncionarioDTO(funcionario.Nome, funcionario.Senha, funcionario.Permissao, funcionario.Salario));

                return Ok();
             }
            return NotFound();
        }

        private ActionResult Excluir(int id)
        {
            FuncionarioModel funcionario = FuncionarioRepository.ObterPorId(id);
            if (funcionario != null)
                FuncionarioRepository.Excluir(funcionario);

            return NoContent();


        }
    }
}
