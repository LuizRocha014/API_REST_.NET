using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController
    {
        private ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_categoryRepository.GetAllCategory(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Category> listCustomer)
        {
            try
            {


                return new JsonResult(_categoryRepository.Add(listCustomer));
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
                return new JsonResult(_categoryRepository.GetAllCategory(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
