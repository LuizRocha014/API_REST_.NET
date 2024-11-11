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
        public IActionResult GetAll(DateTime? ultData)
        {
            try
            {
                return new JsonResult(_userPermissionRepository.GetAll(ultData));
            }
            catch(Exception ) 
            {
                return new JsonResult(null);
            }

        }

        [HttpGet]
        [Route("GetAllId")]
        public IActionResult GetAllId(Guid userId, DateTime? ultData)
        {
            try
            {
                return new JsonResult(_userPermissionRepository.GetAllUserId(userId, ultData));
            }
            catch (Exception)
            {
                return new JsonResult(null);
            }

        }
    }
}
