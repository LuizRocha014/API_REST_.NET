using System;
using System.Runtime.ConstrainedExecution;
using WEB_REST_PRO.Migrations;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
    public interface IShopCostumerRepository : IBaseRepository
    {
        public List<ShopCustomer> GetAll(DateTime? ultDate);
        public List<string> addShopCostumer(List<ShopCustomer> listCustomer);
        public List<ShopCustomer> GetAllId(Guid ShopId, DateTime? ultDate);

    }




}

