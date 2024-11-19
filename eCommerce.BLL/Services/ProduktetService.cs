using AutoMapper;
using eCommerce.BLL.Models.ResponseModels;
using eCommerce.Domain.Interfaces.IModels.IResponseModels;
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
        private readonly IMapper _mapper;

        //inject repo
        public ProduktetService(IProduktetRepository produktetRepository, IMapper mapper)
        {
            _produktetRepository = produktetRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<IResponseModels>> GetProduktet()
        {
            var result = _mapper.Map<IEnumerable<ProduktetResponseModel>>(await _produktetRepository.GetAllAsync());


            //repo
            return await Task.FromResult(result.Cast<IResponseModels>());
            //return new List<Produktet>();
        }
    }
}
