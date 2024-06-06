using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpPost]
        [Route("AddUsuario/")]
        public bool AddUsuario(string nome, string sobrenome, string userId, string email, string senha)
        {
            try
            {
                return _usuarioRepository.AddUsuario(nome, sobrenome, userId, email, senha);
            }
            catch (Exception)
            {

                return false;
            }
        }

        [HttpGet]
        [Route("GetAllUsuarios/")]
        public List<Usuario> GetAllUsuarios()
        {
            try
            {
                return _usuarioRepository.GetAllUsuarios();
            }
            catch (Exception)
            {

                return new List<Usuario>();
            }
        }

        [HttpGet]
        [Route("login")]
        public IActionResult login(string userName, string passWord)
        {
            try
            {
                var conta = _usuarioRepository.login(userName, passWord);
                if(conta!= null)
                return new JsonResult(conta);
                else return new JsonResult(false);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }

    }
}
