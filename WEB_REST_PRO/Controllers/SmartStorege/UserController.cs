using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
                _userRepository = userRepository;
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult login(string userName, string passWord)
        {
            try
            {
                return new JsonResult(_userRepository.login(userName,passWord));
            }
            catch (Exception)
            {
                return new JsonResult(null);

            }
        }
        [HttpPost]
        public IActionResult addLogin([FromBody]User user)
        {
            try
            {
                return new JsonResult(_userRepository.addLogin(user));
            }
            catch (Exception)
            {
                return new JsonResult(null);

            }
        }
    }
}
