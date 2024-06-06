using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class ArquivoRepository : BaseRepository, IArquivoRepository
    {
        private readonly DataContext _dataContext;
        public ArquivoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
