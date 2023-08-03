using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Data.Repository
{
    public class UsuarioAcessoRepository : BaseRepository, IUsuarioAcessoRepository
    {
        private readonly DataContext _dataContext;
        public UsuarioAcessoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }


        public bool AddUsuarioAcesso(Guid usuarioId, Guid acessoId)
        {
            try
            {
                if (_dataContext.Acessos.FirstOrDefault(x => x.Id == acessoId) == null) throw new Exception();
                if (_dataContext.Usuario.FirstOrDefault(x => x.Id == usuarioId) == null) throw new Exception();


                _dataContext.Add(new UsuarioAcesso() { AcessoId = acessoId, UsuarioId = usuarioId, Inclusao = DateTime.Now, Alteracao = DateTime.Now });
                _dataContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<UsuarioAcesso> GetUsuarioAcesso()
        {
            try
            {
                return _dataContext.UsuarioAcesso.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }


    }
}
