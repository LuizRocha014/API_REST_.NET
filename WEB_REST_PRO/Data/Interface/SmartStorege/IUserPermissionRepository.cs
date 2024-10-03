using System;
using System.Collections;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IUserPermissionRepository : IBaseRepository
	{
        public IEnumerable? GetAllUserId(Guid userId, DateTime? ultData);
    }
}

