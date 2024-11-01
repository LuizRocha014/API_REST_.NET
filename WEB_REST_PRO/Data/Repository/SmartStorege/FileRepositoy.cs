﻿using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class SaleRepository : BaseRepository, ISaleRepository
    {
        private readonly DataContext _dataContext;
        public SaleRepository(DataContext dataContext): base(dataContext)
		{
            _dataContext = dataContext;
        }
	}
}

