using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface ICompanyRepository : IBaseRepository
	{
        Company? AddCompany(Company shop);

    }
}

