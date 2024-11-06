
namespace WEB_REST_PRO.Data.Interface.SmartStorege

{
	public interface IRolePermissionRepository : IBaseRepository
	{
        public List<string> AddShopProduct(List<RolePermission> listCustomer);
        public List<RolePermission> GetAllPermission(DateTime? ultimaAtt);

    }
}

