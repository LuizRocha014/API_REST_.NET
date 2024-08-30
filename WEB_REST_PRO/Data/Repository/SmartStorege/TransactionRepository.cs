using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class TransactionRepository : BaseRepository, ITransactionRepository
    {
        private readonly DataContext _dataContext;
        public TransactionRepository(DataContext context) : base(context)
		{
            _dataContext = context;
        }
	}
}

