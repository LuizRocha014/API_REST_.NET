using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

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
        public IActionResult GetAll(Guid userId)
        {
            try
            {
                return new JsonResult(_permissionRepository.GetAllPermission());
            }
            catch (Exception)
            {
                return new JsonResult(null);
            }

        }
    }
}
