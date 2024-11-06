using Microsoft.EntityFrameworkCore;
using System;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        private readonly DataContext _dataContext;
        public CategoryRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }
        public List<Category> GetAllCategory(DateTime? ultDate)
        {
            try
            {
                var list = _dataContext.Category.Where(x => ultDate == null ? (x.Active == true) : (x.UpdatedAt >= ultDate)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Category>();
            }
        }

        public List<string> Add(List<Category> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Category>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

