using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IProductRepository : IBaseRepository
	{
        public List<Product> GetAll(DateTime? ultDate);
        public bool AddShopProduct(Product listCustomer);

    }
}

