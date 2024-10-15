using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShopProductController
    {
        private IShopProductRepository _shopProductRepository;
        public ShopProductController(IShopProductRepository shopProductRepository)
        {
            _shopProductRepository = shopProductRepository;
        }
    }
}
