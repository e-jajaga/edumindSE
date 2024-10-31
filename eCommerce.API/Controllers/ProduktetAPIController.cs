using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BLL.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktetAPIController : ControllerBase
    {
        public ProduktetAPIController()
        {
            //_context = context;
        }

        // GET: api/ProduktetAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produktet>>> GetProduktet()
        {
            return new List<Produktet>();
        }

        
    }
}
