using Microsoft.EntityFrameworkCore;
using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }
        public List<Product> GetAll(DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.Product.Where(x => ultDate == null ? (x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

        public bool AddShopProduct(Product listCustomer)
        {
            try
            {
                var exist = _dataContext.Product.FirstOrDefault(x => x.Id == listCustomer.Id) != null ? false : true;
                if (!exist)
                {
                    try
                    {
                        listCustomer.UpdatedAt = DateTime.Now;
                        _dataContext.Update(listCustomer);
                        _dataContext.SaveChanges();
                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    listCustomer.UpdatedAt = DateTime.Now;
                    _dataContext.Add(listCustomer);
                    _dataContext.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AddProductShop(Product? user)
        {
            try
            {
                if (user != null)
                {
                    var userExist = _dataContext.Set<Product>().AsNoTracking().FirstOrDefault(x => x.Id == user.Id);
                    if (userExist == null)
                    {
                        _dataContext.Add(user);
                        return true;
                    }
                    else
                    {
                        _dataContext.Update(user);
                    }
                    _dataContext.SaveChanges();
                }
               return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
        public Product? GetById(Guid productId)
        {
            try
            {
                var list = _dataContext.Set<Product>().AsNoTracking().FirstOrDefault(x => x.Id == productId);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

