using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserPermissionController
    {
        private IUserPermissionRepository _userPermissionRepository;
        public UserPermissionController(IUserPermissionRepository userPermissionRepository)
        {
            _userPermissionRepository = userPermissionRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll(Guid userId)
        {
            try
            {
                return new JsonResult(_userPermissionRepository.GetAllUserId(userId));
            }
            catch(Exception ) 
            {
                return new JsonResult(null);
            }

        }
    }
}
