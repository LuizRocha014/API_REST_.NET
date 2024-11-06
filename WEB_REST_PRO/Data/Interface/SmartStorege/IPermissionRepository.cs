using System;
using System.Collections;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IPermissionRepository : IBaseRepository
	{
        public List<Permission> GetAllPermission(DateTime? ultimaAtt);
        public List<string> AddShopProduct(List<Permission> listCustomer);

    }
}

