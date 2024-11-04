using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopCustomerController
    {
        private IShopCostumerRepository _shopCostumerRepository;
        public ShopCustomerController(IShopCostumerRepository shopCostumerRepository)
        {
                _shopCostumerRepository = shopCostumerRepository;
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(Guid ShopId, DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_shopCostumerRepository.GetAll(ShopId, ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<ShopCustomer> listCustomer)
        {
            try
            {


                return new JsonResult(_shopCostumerRepository.addShopCostumer(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
