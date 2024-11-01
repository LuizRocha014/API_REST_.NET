using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController
    {
        private ISaleRepository _saleRepository;
        public SaleController(ISaleRepository saleRepository)
        {
                _saleRepository = saleRepository;
        }
    }
}
