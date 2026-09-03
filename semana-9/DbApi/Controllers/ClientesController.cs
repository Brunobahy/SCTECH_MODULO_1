using Microsoft.AspNetCore.Mvc;
using DbApi.Models;

namespace dbApi.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodos()
        {
            // todo: Obter todos os clientes registrados no banco de dados;
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "João da Silva",
                    Telefone = "(11) 99999-9999",
                    Email = "joao.silva@email.com",
                },
                new Cliente()
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Maria Souza",
                    Telefone = "(21) 88888-8888",
                    Email = "maria.souza@email.com",
                },
                new Cliente()
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Pedro Oliveira",
                    Telefone = "(31) 77777-7777",
                    Email = "pedro.oliveira@gmail.com",
                    }
            };

            return Ok(clientes);
        }
        [HttpPost]
        public IActionResult Criar([FromBody] Cliente cliente)
        {
            // todo: salvar o cliente no banco de dados
            return Created();
        }
    }
}