using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;

namespace WEB_REST_PRO.Data.Repository
{
    public class MidiaRepository : BaseRepository, IMidiaRepository
    {
        public  MidiaRepository(DataContext dataContext) : base(dataContext) { }
    }
}
