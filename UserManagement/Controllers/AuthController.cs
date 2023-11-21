using Microsoft.AspNetCore.Mvc;
using UserManagement.Application.AuthenticationService.Dto;
using UserManagement.Application.AuthenticationService.Interface;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        private readonly IAuthenicationService _authenicationService;
        /// <summary>
        /// Builder
        /// </summary>
        /// <param name="logger"></param>
        public AuthController(ILogger<AuthController> logger, IAuthenicationService authenicationService)
        {
            _logger = logger;
            _authenicationService = authenicationService;
        }

        /// <summary>
        /// Iniciar sesion
        /// </summary>
        /// <param name="user">Usuario con Coreo y clave validos</param>
        /// <remarks>
        ///    POST /login
        ///    {"email": "yeinermeri@gmail.com","password": "0123456789"}
        /// </remarks>
        /// <returns>Token de sesión</returns>
        /// <response code="200">Token de sesión</response>
        /// <response code="401">No autorizado</response>
        [HttpPost("login", Name = "login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<string> Login([FromBody] UserLoginDto user)
        {
            return _authenicationService.Login(user);
        }
    }
}
