using System;
using System.Collections;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class UserPermissionsRepository: BaseRepository, IUserPermissionRepository
    {
        private readonly DataContext _dataContext;
        public UserPermissionsRepository(DataContext context) : base(context)
		{
            _dataContext = context;
        }

        public IEnumerable? GetAllUserId (Guid userId, DateTime? ultData)
        {

			try
			{
				return _dataContext.UserPermission.Where(x => x.UsuarioId == userId && (ultData != null ? x.CreatedAt >= ultData : x.Active == true));

            }
			catch (Exception)
			{

				return null;
			}
        }
	}
}

