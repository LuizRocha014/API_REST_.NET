using System;
using System.Collections;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class PermissionRepository : BaseRepository, IPermissionRepository
    {
        private readonly DataContext _dataContext;
        public PermissionRepository(DataContext dataContext) : base(dataContext)
		{
            _dataContext = dataContext;
        }

       public IEnumerable? GetAllPermission()
        {
			try
			{
				return _dataContext.Permission;
			}
			catch (Exception)
			{

				return null;
			}
        }
	}
}

