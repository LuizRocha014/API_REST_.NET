using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShopUserController
    {
        private IShopRepository _iShopRepository;
        public ShopUserController(IShopRepository iShopRepository)
        {
                _iShopRepository = iShopRepository;
        }
    }
}
