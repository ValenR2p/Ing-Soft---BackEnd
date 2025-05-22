using Application.Interface.Product;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductServices _services;
        public ProductoController(IProductServices services)
        {
            _services = services;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(ProductResponse), 200)]
        public async Task<IActionResult> GetProductById(int Id)
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
        [ProducesResponseType(typeof(ProductResponse), 200)]
        public async Task<IActionResult> GetProducts()
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
        [ProducesResponseType(typeof(ProductResponse), 201)]
        public async Task<ActionResult> CreateOrder(ProductRequest request)
        {
            try
            {
                var result = await _services.CreateProduct(request);
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
        [ProducesResponseType(typeof(ProductResponse), 201)]
        public async Task<ActionResult> UpdateOrderDetail(ProductRequest request, int Id)
        {
            try
            {
                var result = await _services.UpdateProduct(request, Id);
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
        [ProducesResponseType(typeof(ProductResponse), 200)]
        public async Task<ActionResult> DeleteProduct(int Id)
        {
            try
            {
                var result = await _services.DeleteProduct(Id);
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
