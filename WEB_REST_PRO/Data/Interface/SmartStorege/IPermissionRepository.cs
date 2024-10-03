using System;
using System.Collections;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IPermissionRepository : IBaseRepository
	{
        public IEnumerable? GetAllPermission(DateTime? ultimaAtt);

    }
}

