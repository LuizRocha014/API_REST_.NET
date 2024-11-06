using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

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

        [Route("GetAll")]
        [HttpGet]
        public IActionResult getAllShopProduct(Guid userId, DateTime? ultDate)
        {
            try
            {
                var retorno = _shopProductRepository.GetAll(userId, ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<ShopProduct> listCustomer)
        {
            try
            {
                var retorno = _shopProductRepository.AddShopProduct(listCustomer);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
