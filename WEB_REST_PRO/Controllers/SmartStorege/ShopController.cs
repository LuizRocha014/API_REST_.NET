using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController
    {
        private IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        [Route("AddNewShop")]
        [HttpPost]
        public IActionResult AddNewShop([FromBody] Shop shop) {

            try
            {
                var retorno = _shopRepository.addShop(shop);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }
    }
}
