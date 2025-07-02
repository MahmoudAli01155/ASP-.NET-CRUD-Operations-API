using FluentValidation;
using Humanizer;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Drawing2D;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Model;
using WebApplicationAPI.Repository.Brand;
using WebApplicationAPI.Validation;

namespace WebApplicationAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        // Dependancy Injection
        public IBrandService BrandService;
        public BrandController(IBrandService _BrandService)
        {
            BrandService = _BrandService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrandgetDTO>>> getAllBrandes()
        {
            var brands = await BrandService.getAllBrandes();
            return Ok(brands);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<BrandgetDTO>> getBrand([FromRoute] int id)
        {
            var brand = await BrandService.GetById(id);
            if (brand == null) return NotFound();
            return Ok(brand);
            // response
        }


        [HttpPost("create")]
        public async Task<ActionResult<BrandgetDTO>> createBrand([FromBody] CreateBrandDTO dTO)
        {
            try
            {
                var result = await BrandService.create(dTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log error
                return StatusCode(500, "Internal server error");
            }
            //var vaidator = new ProductValidator();
            //var vaidator = new ProductValidator();
            //var result = vaidator.Validate(dTO);
            //if (!result.IsValid)
            //{
            //    foreach (var errors in result.Errors)
            //    {
            //        return BadRequest(errors);
            //    }

            //}

            //var product = BrandService.create(dTO);
            //return Ok(product);
        }

        [HttpPut("update")]
        public async Task<ActionResult<BrandgetDTO>> update([FromQuery] int id, [FromBody] UpdateBrandDTO dto)
        {
            var product = await BrandService.update(dto);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var result = BrandService.delete(id);
            return Ok("Delleted");
        }
    }
}
