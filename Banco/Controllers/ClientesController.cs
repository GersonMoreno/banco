using Microsoft.AspNetCore.Mvc;
using ENTITY;
using BLL;
using System.Collections.Generic;
using System.Linq;

namespace Banco.Controllers
{

    [ApiController]
    [Route("api/cliente")]
    public class ClientesController : ControllerBase
    {
        //200 - OK, 400 - BadRequest, 401 - autorize, 500 - Error Internal
        private readonly ClienteService ClienteService;
        public ClientesController()
        {
            ClienteService = new ClienteService();
        }
        [HttpPost("guardarcliente")]
        public ActionResult<string> GuardarCliente(Cliente cliente)
        {
            var respuesta = ClienteService.Guardar(cliente);
            if (respuesta.Equals("Se guardo el cliente correctamente"))
                return Ok(respuesta);
            return BadRequest(respuesta);
        }

        [HttpGet("todosclientes")]
        public ActionResult<List<Cliente>> TodosClientes()
        {
            var respuesta = ClienteService.TodosCLientes();
            if (respuesta.Any())
                return Ok(respuesta);
            return BadRequest(respuesta);
        }
    }
}
