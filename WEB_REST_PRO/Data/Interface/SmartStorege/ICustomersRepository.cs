using System;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ICustomersRepository : IBaseRepository
	{
        public List<string> addCostumer(List<Customer> listCustomer);
        public List<Customer> GetAll( DateTime? ultDate);
        public List<Customer> GetAllId(Guid userId, DateTime? ultDate);
        public bool AddCustomerShop(Customer? user);
        public Customer? GetById(Guid customerId);


    }
}

