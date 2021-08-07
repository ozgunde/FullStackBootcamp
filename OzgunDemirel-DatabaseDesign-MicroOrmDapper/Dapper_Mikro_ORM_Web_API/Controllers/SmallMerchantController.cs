using Dapper_Mikro_ORM_Web_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Mikro_ORM_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmallMerchantController : ControllerBase
    {
        private readonly SmallMerchantRepository smallMerchantRepository;
        public SmallMerchantController()
        {
            smallMerchantRepository = new SmallMerchantRepository();
        }

        //Insert
        [HttpPost]
        public void Post([FromBody]SmallMerchant smallMerchant)
        {
            if (ModelState.IsValid)
                smallMerchantRepository.Add(smallMerchant);
        }
        //Get By ID
        [HttpGet]
        [Route("Get/{id}")]
        public SmallMerchant GetByID(int id)
        {
            return smallMerchantRepository.GetByID(id);
        }
    }
}
