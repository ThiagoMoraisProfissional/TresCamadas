using Microsoft.AspNetCore.Mvc;
using TresCamadas.BLL;
using TresCamadas.Model.Models;

namespace TresCamadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService service)
        {
            _clienteService = service;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var listaClientes = _clienteService.ObterTodosClientes();
            return Ok(listaClientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetClientesById(long paramId)
        {
            var cliente = _clienteService.ObterClientePorId(paramId);

            if (cliente != null)
                return Ok(cliente);

            return NotFound("Cliente não encontrado!");
        }

        [HttpPost]
        public IActionResult CadastrarCliente([FromBody] ClienteModel param)
        {
            var result = _clienteService.CadastrarCliente(param);

            if (result)
                return Ok("Cliente cadastrado com sucesso!");
            

            return BadRequest("Erro ao cadastrar cliente!");

            
        }
    }
}
