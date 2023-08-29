using ApiNetV2.Data;
using ApiNetV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetV2.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ApiController : ControllerBase
    {
        private readonly ClienteInfo _clienteInfo;

        public ApiController(ClienteInfo clienteInfo)
        {
            _clienteInfo = clienteInfo;
        }

        [HttpGet]
        [Route("obtener")]
        public List<DataClient> GetClientes()
        {
            return _clienteInfo.GetClientes();
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic SaveClientes()
        {
            return "h";
        }

    }
}
