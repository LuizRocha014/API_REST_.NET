namespace WEB_REST_PRO.Data.Interface.SmartStorege
{
    public interface IShopProductRepository : IBaseRepository
    {
        List<ShopProduct> GetAll(DateTime? ultDate);
        List<ShopProduct> GetAllId(Guid userId, DateTime? ultDate);
        public List<string> AddShopProduct(List<ShopProduct> listCustomer);
    }
}
