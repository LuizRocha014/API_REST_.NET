using System;
using System.Runtime.ConstrainedExecution;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IShopRepository : IBaseRepository
	{
		Shop? addShop(Shop shop);
        public List<string> AddShopProduct(List<Shop> listCustomer);
        public List<Shop> GetAllPermission(DateTime? ultimaAtt);

    }

	
}

