using Microsoft.EntityFrameworkCore;
using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class CustumerRepository : BaseRepository, ICustomersRepository
    {
        private readonly DataContext _dataContext;
        public CustumerRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<string> addCostumer(List<Customer> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Customer>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

        public List<Customer> GetAll(DateTime? ultDate)
        {
            try
            {
                var listShopCust = (from sp in _dataContext.Set<ShopCustomer>()
                                    join c in _dataContext.Set<Customer>() on sp.CustomerId equals c.Id
                                    where ultDate == null ? ( sp.Active == true && c.Active == true) : (sp.UpdatedAt >= ultDate)
                                    select c).ToList();
                return listShopCust;
            }
            catch (Exception)
            {

                return new List<Customer>();
            }
        }
        public List<Customer> GetAllId(Guid userId, DateTime? ultDate)
        {
            try
            {
                var listShopCust = (from sp in _dataContext.Set<ShopCustomer>()
                                    join c in _dataContext.Set<Customer>() on sp.CustomerId equals c.Id
                                    where ultDate == null ? (sp.ShopId == userId && sp.Active == true && c.Active == true) : (sp.UpdatedAt >= ultDate)
                                    select c).ToList();
                return listShopCust;
            }
            catch (Exception)
            {

                return new List<Customer>();
            }
        }
    }
}

