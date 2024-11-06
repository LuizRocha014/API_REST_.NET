using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class FileRepository : BaseRepository, IFileRepository
    {
        private readonly DataContext _dataContext;
        public FileRepository(DataContext dataContext): base(dataContext)
		{
            _dataContext = dataContext;
        }
	}
}

