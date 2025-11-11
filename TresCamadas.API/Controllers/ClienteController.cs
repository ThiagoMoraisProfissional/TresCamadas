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

        public ClienteController()
        {
            _clienteService = new ClienteService();
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var listaClientes = _clienteService.ObterTodosClientes();
            return Ok(listaClientes);
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
