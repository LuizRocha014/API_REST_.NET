using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolePermissionController
    {
        private IRolePermissionRepository _rolePermissionRepository;

        public RolePermissionController(IRolePermissionRepository rolePermissionRepositor)
        {
            _rolePermissionRepository = rolePermissionRepositor;
        }

        //[Route("AddNewShop")]
        //[HttpPost]
        //public IActionResult PostAll([FromBody] List<RolePermission> listCustomer)
        //{
        //    try
        //    {


        //        return new JsonResult(_rolePermissionRepository.AddShopProduct(listCustomer));
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory( DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_rolePermissionRepository.GetAllPermission(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
