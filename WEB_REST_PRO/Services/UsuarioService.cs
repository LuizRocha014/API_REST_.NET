using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Data;
using WEB_REST_PRO.Models;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public UsuarioService(ApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<Usuario?> GetByEmailAsync(string email)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower() && u.IsActive == true);
        }

        public async Task<Usuario?> CreateAsync(RegisterRequest request)
        {
            // Verificar se o email já existe
            var existingUser = await GetByEmailAsync(request.Email);
            if (existingUser != null)
                return null;

            var usuario = new Usuario
            {
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                Email = request.Email.ToLower(),
                PasswordHash = HashPassword(request.Password),
                UserId = string.IsNullOrEmpty(request.UserId) ? Guid.NewGuid().ToString() : request.UserId,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<LoginResponse> AuthenticateAsync(LoginRequest request)
        {
            var usuario = await GetByEmailAsync(request.Email);

            if (usuario == null || !VerifyPassword(request.Password, usuario.PasswordHash))
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "Email ou senha inválidos."
                };
            }

            var token = _jwtService.GenerateToken(usuario);
            var expiresAt = DateTime.UtcNow.AddMinutes(60); // Configurável via JwtSettings

            return new LoginResponse
            {
                Success = true,
                Token = token,
                ExpiresAt = expiresAt,
                Email = usuario.Email,
                Message = "Login realizado com sucesso."
            };
        }

        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
