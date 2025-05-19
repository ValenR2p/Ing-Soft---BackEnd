using Application.Interface.Cliente;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteServices _services;
        public ClienteController(IClienteServices services)
        {
            _services = services;
        }

        [HttpGet("{ClientId}")]
        [ProducesResponseType(typeof(ClienteResponse), 200)]
        public async Task<IActionResult> GetClientById(int ClientId)
        {
            try
            {
                var result = await _services.GetById(ClientId);
                return new JsonResult(result)
                {
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(ClienteResponse), 200)]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                var result = await _services.GetAll();
                return new JsonResult(result)
                {
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ClienteResponse), 201)]
        public async Task<ActionResult> CreateClient(ClientRequest request)
        {
            try
            {
                var result = await _services.CreateClient(request);
                return new JsonResult(result)
                {
                    StatusCode = 201
                };
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
        }

        [HttpPut("{ClientId}")]
        [ProducesResponseType(typeof(ClienteResponse), 201)]
        public async Task<ActionResult> UpdateClient(ClientRequest request, int ClientId)
        {
            try
            {
                var result = await _services.UpdateClient(request, ClientId);
                return new JsonResult(result)
                {
                    StatusCode = 201
                };
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
        }

        [HttpDelete]
        [ProducesResponseType(typeof(ClienteResponse), 200)]
        public async Task<ActionResult> DeleteClient(int ClientId)
        {
            try
            {
                var result = await _services.DeleteClient(ClientId);
                return new JsonResult(result)
                {
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
        }
    }
}
