using WEB_REST_PRO.Models;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Services
{
    public interface IUsuarioService
    {
        Task<Usuario?> GetByEmailAsync(string email);
        Task<Usuario?> CreateAsync(RegisterRequest request);
        Task<LoginResponse> AuthenticateAsync(LoginRequest request);
        bool VerifyPassword(string password, string hash);
        string HashPassword(string password);
    }
}
