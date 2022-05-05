using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.Dto;
using Services.Operations;

namespace Api.Controllers
{
    [ApiController]
    [Route("pro/{controller}")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _Product;
        public ProductsController(IProductServices Product)
        {
            _Product = Product;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            try
            {
                var prod = await _Product.LoadAllAsync();

                if (prod == null) return NoContent();

                return Ok(prod);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
            }

        }




        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ProductDto ProductView)
        {
            try
            {
                if (ProductView == null) return NoContent();

                var prod = await _Product.InsertAsync(ProductView);

                return Ok(prod);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
            }

        }






    }
}