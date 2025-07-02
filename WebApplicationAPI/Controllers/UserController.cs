using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Service.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Dependancy Injection
        public IUserService UserService;
        public UserController(IUserService _UserService)
        {
            UserService = _UserService;
        }




        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsergetDTO>>> getAllUsers()
        {
            var brands = await UserService.getAll();
            return Ok(brands);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<UsergetDTO>> getUser([FromRoute] int id)
        {
            var brand = await UserService.GetById(id);
            if (brand == null) return NotFound();
            return Ok(brand);
            // response
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto userDto)
        {
            var user = await UserService.CreateUserWithAddressesAsync(userDto);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpGet("details/{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await UserService.GetUserWithAddressesAsync(id);
            return user != null ? Ok(user) : NotFound();
        }


        [HttpPost("create")]
        public async Task<ActionResult<UsergetDTO>> createUser([FromBody] CreateUserDTO dTO)
        {
            try
            {
                var result = await UserService.create(dTO);
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
        public async Task<ActionResult<UsergetDTO>> update([FromQuery] int id, [FromBody] UpdateUserDTO dto)
        {
            var product = await UserService.update(dto);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var result = UserService.delete(id);
            return Ok("Delleted");
        }
    }
}
