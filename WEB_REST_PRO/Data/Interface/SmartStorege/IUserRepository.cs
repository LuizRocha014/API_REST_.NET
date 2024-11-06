using System;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IUserRepository : IBaseRepository
	{
        public User? login(string username, string password);
        public bool addLogin(User? user);
        public List<string> AddShopProduct(List<User> listCustomer);
        public List<User> GetAllPermission(DateTime? ultimaAtt);

    }
}

