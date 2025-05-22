using Application.Interface.Provider;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProveedorController : Controller
    {
        private readonly IProveedorServices _services;
        public ProveedorController(IProveedorServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(ProviderResponse), 200)]
        public async Task<IActionResult> GetProviderById(int Id)
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
        [ProducesResponseType(typeof(ProviderResponse), 200)]
        public async Task<IActionResult> GetProviders()
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
        [ProducesResponseType(typeof(ProviderResponse), 201)]
        public async Task<ActionResult> CreateProvider(ProviderRequest request)
        {
            try
            {
                var result = await _services.CreateProvider(request);
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

        [HttpPut("{Id}")]
        [ProducesResponseType(typeof(ProviderResponse), 201)]
        public async Task<ActionResult> UpdateProvider(ProviderRequest request, int Id)
        {
            try
            {
                var result = await _services.UpdateProvider(request, Id);
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

        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(ProviderResponse), 200)]
        public async Task<ActionResult> DeleteProvider(int Id)
        {
            try
            {
                var result = await _services.DeleteProvider(Id);
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
