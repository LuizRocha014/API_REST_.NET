using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

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
        public IActionResult GetAllCostumer(DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_custumerRepository.GetAll(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAllShopId")]
        [HttpGet]
        public IActionResult GetAllCostumerId(Guid shopId, DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_custumerRepository.GetAll(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("AddCostumerShop")]
        public IActionResult AddUserShop([FromBody] Customer user)
        {
            try
            {
                return new JsonResult(_custumerRepository.AddCustomerShop(user));
            }
            catch (Exception e)
            {
                return new JsonResult(e);

            }
        }

        [Route("GetCustomerById")]
        [HttpGet]
        public IActionResult GetById(Guid customerId)
        {
            try
            {

                var retorno = _custumerRepository.GetById(customerId);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
