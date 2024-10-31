using eCommerce.BLL.IRepositories;
using eCommerce.Domain.Models;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Infrastructure.Repositories
{
    
    public class ProduktetRepository : IProduktetRepository
    {
        private static DB _db;
        public ProduktetRepository(DB db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Produktet>> GetProduktet()
        {
            //repo
            return await _db.Produktet.ToListAsync();
        }
    }
}
