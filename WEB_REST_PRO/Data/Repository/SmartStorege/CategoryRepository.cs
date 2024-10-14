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
        public List<Category>? GetAllCategory()
        {
            try
            {
                return _dataContext.Category.ToList();

            }
            catch (Exception ex)
            {

                return null;
            }
        }

    }
}

