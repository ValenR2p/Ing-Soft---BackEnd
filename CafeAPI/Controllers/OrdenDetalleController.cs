using Application.Interface.OrderDetail;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdenDetalleController : Controller
    {
        private readonly IOrdenDetalleServices _services;
        public OrdenDetalleController(IOrdenDetalleServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(OrderDetailResponse), 200)]
        public async Task<IActionResult> GetOrderDetailById(int Id)
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
        [ProducesResponseType(typeof(OrderDetailResponse), 200)]
        public async Task<IActionResult> GetOrderDetails()
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
        [ProducesResponseType(typeof(OrderDetailResponse), 201)]
        public async Task<ActionResult> CreateOrder(OrderDetailRequest request)
        {
            try
            {
                var result = await _services.CreateOrderDetail(request);
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
        [ProducesResponseType(typeof(OrderDetailResponse), 201)]
        public async Task<ActionResult> UpdateOrderDetail(OrderDetailRequest request, int Id)
        {
            try
            {
                var result = await _services.UpdateOrderDetail(request, Id);
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
        [ProducesResponseType(typeof(OrderDetailResponse), 200)]
        public async Task<ActionResult> DeleteOrderDetail(int Id)
        {
            try
            {
                var result = await _services.DeleteOrderDetail(Id);
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
