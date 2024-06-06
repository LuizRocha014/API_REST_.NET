using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private readonly DataContext _dataContext;
        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
