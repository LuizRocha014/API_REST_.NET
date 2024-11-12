
using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Migrations;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ShopCostumerRepository : BaseRepository, IShopCostumerRepository
    {
        private readonly DataContext _dataContext;
        public ShopCostumerRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }

        public List<string> addShopCostumer(List<ShopCustomer> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<ShopCustomer>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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
                        try
                        {
                            item.UpdatedAt = DateTime.Now;
                            _dataContext.Add(item);
                            _dataContext.SaveChanges();
                            listRetorno.Remove(item.Id.ToString());
                        }
                        catch (Exception)
                        {
                        }
                    }
                }

                return listRetorno;
            }
            catch (Exception)
            {

                return listRetorno;
            }
        }
        public List<ShopCustomer> GetAll(DateTime? ultDate)
        {
            try
            {
                var listShopCust = (from sp in _dataContext.Set<ShopCustomer>()
                                    join c in _dataContext.Set<Customer>() on sp.CustomerId equals c.Id
                                    where ultDate == null ? (sp.Active == true && c.Active == true) : (sp.UpdatedAt >= ultDate)
                                    select sp).ToList();
                return listShopCust;
            }
            catch (Exception)
            {

                return new List<ShopCustomer>();
            }
        } 
        public List<ShopCustomer> GetAllId(Guid ShopId, DateTime? ultDate)
        {
            try
            {
                var listShopCust = (from sp in _dataContext.Set<ShopCustomer>()
                                    join c in _dataContext.Set<Customer>() on sp.CustomerId equals c.Id
                                    where ultDate == null ? (sp.ShopId == ShopId && sp.Active == true && c.Active == true) : (sp.UpdatedAt >= ultDate)
                                    select sp).ToList();
                return listShopCust;
            }
            catch (Exception)
            {

                return new List<ShopCustomer>();
            }
        }
    }
}

