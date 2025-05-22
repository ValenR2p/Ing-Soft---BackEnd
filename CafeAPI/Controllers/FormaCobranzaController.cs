using Application.Interface.PayingMethod;
using Application.Interface.Receipt;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FormaCobranzaController : Controller
    {
        private readonly IFormaCobranzaServices _services;
        public FormaCobranzaController(IFormaCobranzaServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(MethodResponse), 200)]
        public async Task<IActionResult> GetMethodById(int Id)
        {
            try
            {
                var result = await _services.GetById(Id);
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
        [ProducesResponseType(typeof(MethodResponse), 200)]
        public async Task<IActionResult> GetMethods()
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
    }
}
