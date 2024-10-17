using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
	{
        private readonly DataContext _dataContext;
        public CompanyRepository(DataContext dataContext) : base(dataContext)
		{
			_dataContext = dataContext;
		}

        public Company? AddCompany(Company shop)
        {
            try
            {
                var existEntity = _dataContext.Company.FirstOrDefault(x => x.Id == shop.Id);
                if (existEntity == null)
                {
                    _dataContext.Company.Add(shop);
                    _dataContext.SaveChanges();
                }
                var newEntity = _dataContext.Company.FirstOrDefault(x => x.Id == shop.Id);
                return newEntity;


            }
            catch (Exception w)
            {

                return null;
            }
        }
    }
}

