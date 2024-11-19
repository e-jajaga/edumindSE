using eCommerce.Domain.Interfaces.IModels.IResponseModels;
using eCommerce.Domain.IServices;
using eCommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BLL.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktetAPIController : ControllerBase
    {
        private IProduktetService _produktetService;
        public ProduktetAPIController(IProduktetService produktetService)
        {
            _produktetService = produktetService;
            //_context = context;
        }

        // GET: api/ProduktetAPI
        [HttpGet]
        public async Task<IEnumerable<IResponseModels>> GetProduktet()
        {

            return await _produktetService.GetProduktet();
        }

        
    }
}
