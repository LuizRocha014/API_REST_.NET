using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IShopUserRepository : IBaseRepository
	{
        List<ShopUser> GetAll(Guid userId, DateTime? ultDate);

    }
}

