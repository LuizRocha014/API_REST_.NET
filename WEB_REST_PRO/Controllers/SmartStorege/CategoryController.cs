using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

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
        public IActionResult GetAllCategory(int page, int pageSize)
        {
            try
            {
                return new JsonResult(_categoryRepository.GetAllCategory(page,pageSize));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
