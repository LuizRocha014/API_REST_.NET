using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class CategoriaAgendaRepository : BaseRepository, ICategoriaAgendaRepository
    {
        private readonly DataContext _dataContext;
        public CategoriaAgendaRepository(DataContext dataContext) : base(dataContext)
        {
                _dataContext = dataContext; 
        }
    }
}
