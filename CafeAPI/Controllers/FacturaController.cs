using Application.Interface.Facture;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FacturaController : Controller
    {
        private readonly IFacturaServices _services;
        public FacturaController(IFacturaServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(FactureResponse), 200)]
        public async Task<IActionResult> GetFactureById(int Id)
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
        [ProducesResponseType(typeof(FactureResponse), 200)]
        public async Task<IActionResult> GetFactures()
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
        [ProducesResponseType(typeof(FactureResponse), 201)]
        public async Task<ActionResult> CreateFacture(FactureRequest request)
        {
            try
            {
                var result = await _services.CreateFacture(request);
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
        [ProducesResponseType(typeof(FactureResponse), 201)]
        public async Task<ActionResult> UpdateFacture(FactureRequest request, int Id)
        {
            try
            {
                var result = await _services.UpdateFacture(request, Id);
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
