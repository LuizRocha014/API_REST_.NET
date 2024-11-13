using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IProductFileRepository : IBaseRepository
	{
        public List<ProductFile> GetAll(DateTime? ultDate);
        public bool AddShopProduct(ProductFile listCustomer);


    }
}

