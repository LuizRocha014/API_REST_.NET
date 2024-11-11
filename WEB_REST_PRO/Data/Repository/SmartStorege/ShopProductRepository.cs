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
        } public List<ShopProduct> GetAllId(Guid userId, DateTime? ultDate)
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

        public List<string> AddShopProduct(List<ShopProduct> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<ShopProduct>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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
