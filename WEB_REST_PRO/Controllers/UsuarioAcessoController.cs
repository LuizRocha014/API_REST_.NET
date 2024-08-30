using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Data.Repository;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioAcessoController
    {

    //    private IUsuarioAcessoRepository _usuarioAcessoRepository;
    //    public UsuarioAcessoController(IUsuarioAcessoRepository usuarioAcessoRepository)
    //    {
    //        _usuarioAcessoRepository = usuarioAcessoRepository;
            
    //    }

    //    [HttpPost]
    //    [Route("AddUsuarioAcesso/")]
    //    public ActionResult<bool> AddUsuarioAcesso(Guid usuarioId, Guid acessoId)
    //    {

    //        try
    //        {
    //            return _usuarioAcessoRepository.AddUsuarioAcesso(usuarioId, acessoId);
    //        }
    //        catch (Exception)
    //        {

    //            return false;
    //        }
    //    }

    //    [HttpGet]
    //    [Route("GetUsuariosAcessos/")]
    //    public ActionResult<List<UsuarioAcesso>> GetUsuariosAcessos()
    //    {

    //        try
    //        {
    //            return _usuarioAcessoRepository.GetUsuarioAcesso();
    //        }
    //        catch (Exception)
    //        {

    //            return null;
    //        }
    //    }
    }
}
