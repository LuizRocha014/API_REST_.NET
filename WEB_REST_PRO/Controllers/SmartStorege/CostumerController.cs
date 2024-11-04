using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class CostumerController
    {
        private ICustomersRepository _custumerRepository;
        public CostumerController(ICustomersRepository custumerRepository)
        {
            _custumerRepository = custumerRepository;
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Customer> listCustomer)
        {
            try
            {
                

                return new JsonResult(_custumerRepository.addCostumer(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(Guid shopId, DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_custumerRepository.GetAll(shopId, ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
