using Microsoft.EntityFrameworkCore;
using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class SaleRepository : BaseRepository, ISaleRepository
	{
        private readonly DataContext _dataContext;
        public SaleRepository(DataContext dataContext): base(dataContext)
		{
            _dataContext = dataContext;
        }
        public List<Sale> GetAllPermission(DateTime? ultimaAtt)
        {
            try
            {
                var list = _dataContext.Sale.Where(x => ultimaAtt == null ? (x.Active == true) : (x.UpdatedAt >= ultimaAtt)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Sale>();
            }
        }
        public List<string> AddShopProduct(List<Sale> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Sale>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

