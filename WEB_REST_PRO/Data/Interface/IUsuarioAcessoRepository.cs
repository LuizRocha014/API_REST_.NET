using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Data.Interface
{
    public interface IUsuarioAcessoRepository  
    {
        bool AddUsuarioAcesso(Guid usuarioId, Guid acessoId);
        List<UsuarioAcesso> GetUsuarioAcesso();
    }
}
