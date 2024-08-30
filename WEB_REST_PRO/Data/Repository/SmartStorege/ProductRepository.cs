using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext context) : base(context)
		{
            _dataContext = context;
        }
	}
}

