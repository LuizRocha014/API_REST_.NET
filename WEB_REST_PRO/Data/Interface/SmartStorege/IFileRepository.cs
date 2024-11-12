using System;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
	public interface IFileRepository : IBaseRepository
	{
        public List<File>? GetAllCategory(DateTime? ultDate);
        public List<string> Add(List<File> listCustomer);
    }
}

