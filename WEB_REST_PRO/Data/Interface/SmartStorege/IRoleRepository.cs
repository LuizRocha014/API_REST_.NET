using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IRoleRepository : IBaseRepository
	{
        public List<string> AddShopProduct(List<Role> listCustomer);
        public List<Role> GetAllPermission(DateTime? ultimaAtt);

    }
}

