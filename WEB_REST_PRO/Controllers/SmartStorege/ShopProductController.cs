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
        public IActionResult getAllShopProduct(DateTime? ultDate)
        {
            try
            {
                var retorno = _shopProductRepository.GetAll(ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }
        [Route("GetAllId")]
        [HttpGet]
        public IActionResult GetAllId(Guid userId, DateTime? ultDate)
        {
            try
            {
                var retorno = _shopProductRepository.GetAllId(userId, ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] ShopProduct shopProduct)
        {
            try
            {


                return new JsonResult(_shopProductRepository.AddShopProduct(shopProduct));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
