using System;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ITransactionRepository : IBaseRepository
	{
        public List<string> AddShopProduct(List<Transactions> listCustomer);
        public List<Transactions> GetAllPermission(DateTime? ultimaAtt);
    }
}

