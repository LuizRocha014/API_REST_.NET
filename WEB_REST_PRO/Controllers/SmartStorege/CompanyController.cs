using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController
    {
        private ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [Route("AddCompany")]
        [HttpPost]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                var retorno = _companyRepository.AddCompany(company);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }
        [Route("PostAll")]
        [HttpPost]
        public IActionResult PostAll([FromBody] List<Company> listCustomer)
        {
            try
            {


                return new JsonResult(_companyRepository.AddCompanyList(listCustomer));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCategory(DateTime? ultDate)
        {
            try
            {
                return new JsonResult(_companyRepository.GetAllCategory(ultDate));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

