using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Data.Interface
{
    public interface IAcessoRepository
    {
        bool AddUsuario(string nome, string valor, string descricao);
        //List<Acessos> GetAcessos();
    }
}
