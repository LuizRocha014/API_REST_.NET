using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController
    {
        private ITransactionRepository _repository;
        public TransactionController(ITransactionRepository repsoitory)
        {
            _repository = repsoitory;
        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Transactions> listCustomer)
        {
            try
            {


                return new JsonResult(_repository.AddShopProduct(listCustomer));
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
                return new JsonResult(_repository.GetAllPermission(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
