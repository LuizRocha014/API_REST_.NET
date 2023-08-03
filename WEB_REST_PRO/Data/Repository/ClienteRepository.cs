using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class ClienteRepository : BaseRepository , IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext) : base(dataContext)
        {
                _dataContext = dataContext;
        }
        
    }
}
