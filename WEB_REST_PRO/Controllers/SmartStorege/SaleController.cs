using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController
    {
        private ISaleRepository _saleRepository;
        public SaleController(ISaleRepository saleRepository)
        {
                _saleRepository = saleRepository;
        }
        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Sale> listCustomer)
        {
            try
            {


                return new JsonResult(_saleRepository.AddShopProduct(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory( DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_saleRepository.GetAllPermission(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
