using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ICustomersRepository : IBaseRepository
	{
        public List<string> addCostumer(List<Customer> listCustomer);
        public List<Customer> GetAll(Guid ShopId, DateTime? ultDate);

    }
}

