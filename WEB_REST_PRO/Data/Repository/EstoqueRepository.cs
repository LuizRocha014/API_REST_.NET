using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class EstoqueRepository : BaseRepository, IEstoqueRepository
    {
        private readonly DataContext _dataContext;
        public EstoqueRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
