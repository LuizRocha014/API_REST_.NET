using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController
    {
        private IFileRepository _fileRepository;
        public FileController(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_fileRepository.GetAllCategory(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<File> listCustomer)
        {
            try
            {


                return new JsonResult(_fileRepository.Add(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAllId")]
        [HttpGet]
        public IActionResult GetAll( DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_fileRepository.GetAllCategory(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
