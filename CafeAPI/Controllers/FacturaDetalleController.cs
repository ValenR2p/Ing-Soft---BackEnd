using Application.Interface.FactureDetail;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FacturaDetalleController : Controller
    {
        private readonly IFacturaDetalleServices _services;
        public FacturaDetalleController(IFacturaDetalleServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(FactureDetailResponse), 200)]
        public async Task<IActionResult> GetFactureDetailById(int Id)
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
        [ProducesResponseType(typeof(FactureDetailResponse), 200)]
        public async Task<IActionResult> GetFactureDetails()
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
        [ProducesResponseType(typeof(FactureDetailResponse), 201)]
        public async Task<ActionResult> CreateFactureDetail(FactureDetailRequest request)
        {
            try
            {
                var result = await _services.CreateFactureDetail(request);
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
    }
}
