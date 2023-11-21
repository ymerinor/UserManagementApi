using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Application.UsersServices.Interface;
using UserManagement.Domain.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        public readonly IUserManagementService _userManagementService;

        public UserController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<Users>> Get()
        {
            return await _userManagementService.ListarAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var resultadoConsulta = await _userManagementService.BuscarPorIdAsync(id);
            return Ok(resultadoConsulta);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Users users)
        {
            await _userManagementService.CrearAsync(users);
            return Ok(users);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Users users)
        {
            await _userManagementService.EditarAsync(users);
            return Ok(users);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _userManagementService.EliminarAsync(id);
            return Ok();
        }

        [HttpGet("paginado")]
        public async Task<IActionResult> GetUsers([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var users = await _userManagementService.ListadoPaginado(page, pageSize);
            return Ok(users);
        }
    }
}
