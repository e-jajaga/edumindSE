using eCommerce.Domain.IRepositories;
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
    
    public class ProduktetRepository : GenericRepository<Produktet>, IProduktetRepository
    {
        private DB _context;
        public ProduktetRepository(DB context) : base(context) {
            _context = context;
        }

        public void AddProductReview(string comment)
        {
            throw new NotImplementedException();
        }
    }
}
