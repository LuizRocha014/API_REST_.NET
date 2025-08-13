using WEB_REST_PRO.Models;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Services
{
    public interface IJwtService
    {
        string GenerateToken(Usuario usuario);
        bool ValidateToken(string token);
        string GetEmailFromToken(string token);
    }
}
