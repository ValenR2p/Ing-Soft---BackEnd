using Application.Interface.Order;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdenController : Controller
    {
        private readonly IOrdenServices _services;
        public OrdenController(IOrdenServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(OrderResponse), 200)]
        public async Task<IActionResult> GetOrderById(int Id)
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
        [ProducesResponseType(typeof(OrderResponse), 200)]
        public async Task<IActionResult> GetOrders()
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
        [ProducesResponseType(typeof(OrderResponse), 201)]
        public async Task<ActionResult> CreateOrder(OrderRequest request)
        {
            try
            {
                var result = await _services.CreateOrder(request);
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
        [ProducesResponseType(typeof(OrderResponse), 201)]
        public async Task<ActionResult> UpdateOrder(OrderRequest request, int Id)
        {
            try
            {
                var result = await _services.UpdateOrder(request, Id);
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
        [ProducesResponseType(typeof(OrderResponse), 200)]
        public async Task<ActionResult> DeleteOrder(int Id)
        {
            try
            {
                var result = await _services.DeleteOrder(Id);
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
