using AutoMapper;
using eCommerce.BLL.Models.RequestModels;
using eCommerce.BLL.Models.ResponseModels;
using eCommerce.Domain.IServices;
using eCommerce.Domain.IRepositories;
using eCommerce.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Domain.Interfaces.IModels.IRequestModels;
using eCommerce.Domain.Interfaces.IModels.IResponseModels;

namespace eCommerce.BLL.Services
{
    public class ProduktetService : IProduktetService
    {
        private readonly IProduktetRepository _produktetRepository;
        private readonly IMapper _mapper;

        public ProduktetService(IProduktetRepository produktetRepository, IMapper mapper)
        {
            _produktetRepository = produktetRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IResponseModels>> GetProduktet()
        {
            var products = await _produktetRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<ProduktetResponseModel>>(products);
            return response.Cast<IResponseModels>();
        }

        public async Task<IResponseModels> GetProduktById(int id)
        {
            var product = await _produktetRepository.GetByIdAsync(id);
            if (product == null)
                return null;

            return _mapper.Map<ProduktetResponseModel>(product);
        }

        public async Task<IResponseModels> CreateProdukt(IRequestModels produktRequest)
        {
            var request = produktRequest as ProduktetRequestModel;

            if (request == null)
                throw new InvalidCastException("Invalid request model.");

            var productEntity = _mapper.Map<Produktet>(request);
            await _produktetRepository.AddAsync(productEntity);

            return _mapper.Map<ProduktetResponseModel>(productEntity);
        }

        public async Task UpdateProdukt(IRequestModels produktRequest)
        {
            var request = produktRequest as ProduktetRequestModel;

            if (request == null)
                throw new InvalidCastException("Invalid request model.");

            var productEntity = _mapper.Map<Produktet>(request);
            await _produktetRepository.UpdateAsync(productEntity);
        }

        public async Task DeleteProdukt(int id)
        {
            var product = await _produktetRepository.GetByIdAsync(id);

            if (product != null)
            {
                await _produktetRepository.DeleteAsync(product);
            }
        }
    }
}
