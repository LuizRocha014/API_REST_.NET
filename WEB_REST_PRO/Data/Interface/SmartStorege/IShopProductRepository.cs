namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
    public interface IShopProductRepository : IBaseRepository
    {
        List<ShopProduct> GetAll(Guid userId, DateTime? ultDate);
        public List<string> addCostumer(List<ShopProduct> listCustomer);
    }
}
