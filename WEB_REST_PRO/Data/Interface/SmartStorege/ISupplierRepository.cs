using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ISupplierRepository : IBaseRepository
	{
        public List<string> AddShopProduct(List<Supplier> listCustomer);
        public List<Supplier> GetAllPermission(DateTime? ultimaAtt);
    }
}

