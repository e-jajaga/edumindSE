using eCommerce.Domain.IRepositories;
using eCommerce.Domain.IServices;
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
        private IProduktetRepository _produktetRepository;
        //inject repo
        public ProduktetService(IProduktetRepository produktetRepository)
        {
            _produktetRepository = produktetRepository;
        }
        public async Task<IEnumerable<Produktet>> GetProduktet()
        {
            //repo
            return await _produktetRepository.GetAllAsync();
            //return new List<Produktet>();
        }
    }
}
