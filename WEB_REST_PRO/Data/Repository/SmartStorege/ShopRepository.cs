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
           

	}
}

