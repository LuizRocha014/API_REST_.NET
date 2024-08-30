﻿using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class ProductFileRepository : BaseRepository, IProductFileRepository
    {
        private readonly DataContext _dataContext;
        public ProductFileRepository(DataContext context) : base(context)
		{
            _dataContext = context;
        }
	}
}
