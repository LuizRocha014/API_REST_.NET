using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController
    {
        private IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        [HttpGet]
        [Route("GetAcessos")]
        public IActionResult GetAll( DateTime? ultData)
        {
            try
            {
                return new JsonResult(_permissionRepository.GetAllPermission(ultData));
            }
            catch (Exception)
            {
                return new JsonResult(null);
            }

        }

        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Permission> listCustomer)
        {
            try
            {


                return new JsonResult(_permissionRepository.AddShopProduct(listCustomer));
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
                return new JsonResult(_permissionRepository.GetAllPermission(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
