using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShopUserController
    {
        private IShopUserRepository _iShopRepository;
        public ShopUserController(IShopUserRepository iShopRepository)
        {
            _iShopRepository = iShopRepository;
        }

        [Route("GetAllId")]
        [HttpGet]
        public IActionResult getAllShopUser (Guid userId, DateTime? ultDate)
        {
            try
            {
                var retorno  = _iShopRepository.GetAllId(userId, ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<ShopUser> listCustomer)
        {
            try
            {


                return new JsonResult(_iShopRepository.AddShopProduct(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_iShopRepository.GetAllPermission(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
