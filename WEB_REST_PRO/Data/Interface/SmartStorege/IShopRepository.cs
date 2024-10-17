using System;
using System.Runtime.ConstrainedExecution;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IShopRepository : IBaseRepository
	{
		Shop? addShop(Shop shop);

    }

	
}

