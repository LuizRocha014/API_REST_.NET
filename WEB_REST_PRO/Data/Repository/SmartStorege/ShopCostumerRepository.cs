
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Migrations;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ShopCostumerRepository : BaseRepository, IShopCostumerRepository
    {
        private readonly DataContext _dataContext;
        public ShopCostumerRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }


        public List<ShopCustomer> GetAll(Guid ShopId, DateTime? ultDate)
        {
            try
            {
              var list =  _dataContext.ShopCustomer.Where(x => ultDate == null ? (x.ShopId == ShopId && x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {

                return new List<ShopCustomer>();
            }
        }
    }
}

