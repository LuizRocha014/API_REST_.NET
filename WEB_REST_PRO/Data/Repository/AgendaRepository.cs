using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class AgendaRepository : BaseRepository, IAgendaRepository
    {
        private readonly DataContext _dataContext;
        public AgendaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
