using eCommerce.BLL.IServices;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Services
{
    public class ProduktetService : IProduktetService
    {
        //inject repo
        public async Task<IEnumerable<Produktet>> GetProduktet()
        {
            //repo
            //return await _context.Produktet.ToListAsync();
            return null;
        }
    }
}
