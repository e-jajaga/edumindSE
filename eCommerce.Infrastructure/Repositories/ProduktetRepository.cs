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
        public ProduktetRepository(DbContext context) : base(context) { }
    }
}
