﻿using Microsoft.AspNetCore.Mvc;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Controllers.SmartStorege
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShopUserController
    {
        private IShopUserRepository _iShopRepository;
        public ShopUserController(IShopUserRepository iShopRepository)
        {
            _iShopRepository = iShopRepository;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult getAllShopUser (Guid userId, DateTime? ultDate)
        {
            try
            {
                var retorno  = _iShopRepository.GetAll(userId, ultDate);
                return new JsonResult(retorno);
            }
            catch (Exception)
            {

                return new JsonResult(false);
            }
        }
    }
}
