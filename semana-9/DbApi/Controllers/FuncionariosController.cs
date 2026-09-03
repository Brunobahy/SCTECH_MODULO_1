using Microsoft.AspNetCore.Mvc;
using DbApi.Models;

namespace dbApi.Controllers
{
    [ApiController]
    [Route("funcionarios")]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Funcionario
                {

                    Funcao = "Gerente",
                    Dados = new Cliente
                    {
                        Id = Guid.NewGuid().ToString(),
                        Nome = "João da Silva",
                        Telefone = "(11) 99999-9999",
                        Email = "joao.silva@gmail.com"
                    }
                }
            };
            // Todo: pegar todos funcionarios em uma lista e enviar
            return Ok(funcionarios);
        }
        [HttpPost("criar")]
        public IActionResult CriarFuncionario([FromBody] Funcionario funcionario)
        {

            return Created();
        }


    }
}