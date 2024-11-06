using System;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
    public interface ICategoryRepository : IBaseRepository
    {
        public List<Category>? GetAllCategory(DateTime? ultDate);
        public List<string> Add(List<Category> listCustomer);
    }
}

