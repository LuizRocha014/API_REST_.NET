using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IShopUserRepository : IBaseRepository
	{
        public List<ShopUser> GetAllId(Guid userId, DateTime? ultDate);
         List<string> AddShopProduct(List<ShopUser> listCustomer);
         List<ShopUser> GetAllPermission(DateTime? ultimaAtt);

    }
}

