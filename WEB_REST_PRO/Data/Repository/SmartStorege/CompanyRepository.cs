using Microsoft.EntityFrameworkCore;
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
        public List<Company> GetAllCategory(DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.Company.Where(x => ultDate == null ? (x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Company>();
            }
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

        public List<string> AddCompanyList(List<Company> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Company>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
                    if (exist)
                    {
                        try
                        {
                            item.UpdatedAt = DateTime.Now;
                            _dataContext.Update(item);
                            _dataContext.SaveChanges();
                            listRetorno.Remove(item.Id.ToString());
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else
                    {
                        item.UpdatedAt = DateTime.Now;
                        _dataContext.Add(item);
                        _dataContext.SaveChanges();
                        listRetorno.Remove(item.Id.ToString());
                    }
                }

                return listRetorno;
            }
            catch (Exception)
            {

                return listRetorno;
            }
        }
    }
}

