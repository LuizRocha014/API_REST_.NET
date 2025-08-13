using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Models;
using WEB_REST_PRO.Services;

namespace WEB_REST_PRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AuthController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _usuarioService.CreateAsync(request);
            
            if (usuario == null)
            {
                return BadRequest(new { message = "Email já está em uso." });
            }

            return Ok(new 
            { 
                message = "Usuário criado com sucesso!",
                userId = usuario.Id,
                email = usuario.Email
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _usuarioService.AuthenticateAsync(request);

            if (!response.Success)
            {
                return Unauthorized(new { message = response.Message });
            }

            return Ok(response);
        }

        [HttpGet("profile")]
        [Authorize]
        public async Task<IActionResult> GetProfile()
        {
            var email = User.Identity?.Name;
            
            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized();
            }

            var usuario = await _usuarioService.GetByEmailAsync(email);
            
            if (usuario == null)
            {
                return NotFound(new { message = "Usuário não encontrado." });
            }

            return Ok(new 
            {
                id = usuario.Id,
                nome = usuario.Nome,
                sobrenome = usuario.Sobrenome,
                email = usuario.Email,
                userId = usuario.Id,
                createdAt = usuario.CreatedAt
            });
        }

        [HttpGet("validate")]
        [Authorize]
        public IActionResult ValidateToken()
        {
            return Ok(new { message = "Token válido", user = User.Identity?.Name });
        }
    }
}
