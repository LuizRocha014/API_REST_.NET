using System;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ISaleRepository : IBaseRepository
	{
        public List<string> AddShopProduct(List<Sale> listCustomer);

        public List<Sale> GetAllPermission(DateTime? ultimaAtt);
    }
}

