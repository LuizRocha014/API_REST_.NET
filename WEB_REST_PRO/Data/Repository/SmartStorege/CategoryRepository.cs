using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class CategoryRepository : BaseRepository, ICategoryRepository
	{
		public CategoryRepository(DataContext context) : base(context)
		{
		}
	}
}

