using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Data.Repository
{
    public class AcessoRepository : BaseRepository, IAcessoRepository
    {
        private readonly DataContext _dataContext;
        public AcessoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddUsuario(string nome, string valor, string descricao)
        {
            try
            {

                var acesso = new Acessos()
                {
                    Nome = nome,
                    Valor = valor,
                    Descricao = descricao,
                    Alteracao = DateTime.Now,
                    Inclusao = DateTime.Now,
                };
                _dataContext.Add(acesso);
                _dataContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }


        public List<Acessos> GetAcessos()
        {
            try
            {

                
                return _dataContext.Acessos.ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
