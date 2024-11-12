using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ShopProductRepository : BaseRepository, IShopProductRepository
    {
        private readonly DataContext _dataContext;
        public ShopProductRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }


        public List<ShopProduct> GetAll(DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.ShopProduct.Where(x => ultDate == null ? (x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {

                return new List<ShopProduct>();
            }
        }
        public List<ShopProduct> GetAllId(Guid userId, DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.ShopProduct.Where(x => ultDate == null ? (x.UserId == userId && x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {

                return new List<ShopProduct>();
            }
        }

        public bool AddShopProduct([FromBody] ShopProduct shopProduct)
        {

            try
            {
                var exist = _dataContext.Set<ShopProduct>().AsNoTracking().FirstOrDefault(x => x.Id == shopProduct.Id) != null ? true : false;
                if (exist)
                {
                    try
                    {
                        shopProduct.UpdatedAt = DateTime.Now;
                        _dataContext.Update(shopProduct);
                        _dataContext.SaveChanges();
                    }
                    catch (Exception)
                    {
                        return false;

                    }

                }
                else
                {
                    try
                    {
                        shopProduct.UpdatedAt = DateTime.Now;
                        _dataContext.Add(shopProduct);
                        _dataContext.SaveChanges();
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
