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


        public List<ShopProduct> GetAll(Guid userId, DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.ShopProduct.Where(x => ultDate == null ? (x.UserId == userId && x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {

                return new List<ShopProduct>();
            }
        }
    }
}
