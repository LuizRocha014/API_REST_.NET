using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ShopProductRepository : BaseRepository, IShopProductRepository
    {
        private readonly DataContext _dataContext;
        public ShopProductRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}
