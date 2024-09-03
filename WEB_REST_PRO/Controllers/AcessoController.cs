using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    ////["application/json"]
    //public class AcessoController
    //{
    //    private IAcessoRepository _acessoRepository;

    //    public AcessoController(IAcessoRepository acessoRepository)
    //    {
    //        _acessoRepository = acessoRepository;
    //    }
        
    //    [HttpPost]
    //    [Route("AddAcesso/")]
    //    public bool AddAcesso(string nome, string valor, string descricao)
    //    {
    //        try
    //        {
    //            return _acessoRepository.AddUsuario(nome, valor, descricao);
    //        }
    //        catch (Exception)
    //        {

    //            return false;
    //        }
    //    }


    //    [HttpGet]
    //    [Route("GetAcessos")]
    //    public IActionResult GetAcessos(Guid userId)
    //    {
    //        try     
    //        {
    //             return new JsonResult(_acessoRepository.GetAcessos());
    //        }
    //        catch (Exception)
    //        {

    //            return null;
    //        }
    //    }
    //}
}
