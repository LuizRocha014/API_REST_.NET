using System;
using System.Runtime.ConstrainedExecution;
using WEB_REST_PRO.Migrations;
using WEB_REST_PRO.Models.SmartStorege;
namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
    public interface IShopCostumerRepository : IBaseRepository
    {
        public List<ShopCustomer> GetAll(Guid ShopId, DateTime? ultDate);

    }


}

