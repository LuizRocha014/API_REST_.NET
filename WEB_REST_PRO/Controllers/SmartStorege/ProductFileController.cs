using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductFileController 
    {
        private IProductFileRepository _productFileRepository;

        public ProductFileController(IProductFileRepository productFileRepository)
        {
            _productFileRepository = productFileRepository;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult getAllShopProduct(DateTime? ultDate)
        {
            try
            {
                var retorno = _productFileRepository.GetAll(ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] ProductFile listCustomer)
        {
            try
            {

                var retorno = _productFileRepository.AddShopProduct(listCustomer);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
