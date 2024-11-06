using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult getAllShopProduct( DateTime? ultDate)
        {
            try
            {
                var retorno = _productRepository.GetAll(ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Product> listCustomer)
        {
            try
            {


                return new JsonResult(_productRepository.AddShopProduct(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
