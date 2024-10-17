using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ShopUserRepository : BaseRepository, IShopUserRepository
    {
        private readonly DataContext _dataContext;
        public ShopUserRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }


        public List<ShopUser> GetAll(Guid userId, DateTime? ultDate)
        {
            try
            {
              var list =  _dataContext.ShopUser.Where(x => ultDate == null ? (x.UserId == userId && x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {

                return new List<ShopUser>();
            }
        }
    }
}

