using System;
using System.Collections;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IUserPermissionRepository : IBaseRepository
	{
        public List<UserPermission>? GetAllUserId(Guid userId, DateTime? ultData);
        public List<UserPermission>? GetAll(DateTime? ultData);
        public List<string> AddShopProduct(List<UserPermission> listCustomer);
        public List<UserPermission> GetAllPermission(DateTime? ultimaAtt);
    }
}

