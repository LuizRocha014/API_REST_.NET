using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.ConstrainedExecution;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class ShopRepository: BaseRepository, IShopRepository
    {
        private readonly DataContext _dataContext;
        public ShopRepository(DataContext context) : base(context)
		{
            _dataContext = context;
        }

        public Shop? addShop(Shop shop)
        {
			try
			{
				var existEntity = _dataContext.Shop.FirstOrDefault(x => x.Id == shop.Id);
				if (existEntity == null)
				{
					_dataContext.Shop.Add(shop);
					_dataContext.SaveChanges();
				}
				var newEntity = _dataContext.Shop.FirstOrDefault(x=>x.Id == shop.Id);
				return newEntity;


            }
			catch (Exception)
			{

				return null;	
			}
        }
        public List<Shop> GetAllPermission(DateTime? ultimaAtt)
        {
            try
            {
                var list = _dataContext.Shop.Where(x => ultimaAtt == null ? (x.Active == true) : (x.UpdatedAt >= ultimaAtt)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Shop>();
            }
        }
        public List<string> AddShopProduct(List<Shop> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Shop>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

