using eCommerce.BLL.Models.RequestModels;
using eCommerce.BLL.Models.ResponseModels;
using eCommerce.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.BLL.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktetAPIController : ControllerBase
    {
        private readonly IProduktetService _produktetService;

        public ProduktetAPIController(IProduktetService produktetService)
        {
            _produktetService = produktetService;
        }

        // GET: api/ProduktetAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProduktetResponseModel>>> GetProduktet()
        {
            var products = await _produktetService.GetProduktet();
            return Ok(products.Cast<ProduktetResponseModel>());
        }

        // GET: api/ProduktetAPI/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ProduktetResponseModel>> GetProduktById(int id)
        {
            var product = await _produktetService.GetProduktById(id);

            if (product == null)
                return NotFound();

            return Ok((ProduktetResponseModel)product);
        }

        // POST: api/ProduktetAPI
        [HttpPost]
        public async Task<ActionResult<ProduktetResponseModel>> CreateProdukt([FromBody] ProduktetRequestModel produktRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdProduct = await _produktetService.CreateProdukt(produktRequest);
            return CreatedAtAction(nameof(GetProduktById), new { id = ((ProduktetResponseModel)createdProduct).Numri }, createdProduct);
        }

        // PUT: api/ProduktetAPI/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProdukt(int id, [FromBody] ProduktetRequestModel produktRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != produktRequest.Numri)
                return BadRequest("ID in URL and model do not match.");

            await _produktetService.UpdateProdukt(produktRequest);
            return NoContent();
        }

        // DELETE: api/ProduktetAPI/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdukt(int id)
        {
            var product = await _produktetService.GetProduktById(id);

            if (product == null)
                return NotFound();

            await _produktetService.DeleteProdukt(id);
            return NoContent();
        }
    }
}
