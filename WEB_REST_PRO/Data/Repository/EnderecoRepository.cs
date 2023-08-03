using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        private readonly DataContext _dataContext;

        public EnderecoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        
    }
}
