using Application.Interface.Receipt;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CobranzaController : Controller
    {
        private readonly ICobranzaServices _services;
        public CobranzaController(ICobranzaServices services)
        {
            _services = services;
        }

        [HttpGet("{ReceiptId}")]
        [ProducesResponseType(typeof(ReceiptResponse), 200)]
        public async Task<IActionResult> GetReceiptById(int ReceiptId)
        {
            try
            {
                var result = await _services.GetById(ReceiptId);
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
        [ProducesResponseType(typeof(ReceiptResponse), 200)]
        public async Task<IActionResult> GetReceipts()
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
        [ProducesResponseType(typeof(ReceiptResponse), 201)]
        public async Task<ActionResult> CreateReceipt(ReceiptRequest request)
        {
            try
            {
                var result = await _services.CreateReceipt(request);
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

        [HttpPut("{ReceiptId}")]
        [ProducesResponseType(typeof(ReceiptResponse), 201)]
        public async Task<ActionResult> UpdateReceipt(ReceiptRequest request, int ReceiptId)
        {
            try
            {
                var result = await _services.UpdateReceipt(request, ReceiptId);
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

        [HttpDelete("{ReceiptId}")]
        [ProducesResponseType(typeof(ReceiptResponse), 200)]
        public async Task<ActionResult> DeleteReceipt(int ReceiptId)
        {
            try
            {
                var result = await _services.DeleteReceipt(ReceiptId);
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
