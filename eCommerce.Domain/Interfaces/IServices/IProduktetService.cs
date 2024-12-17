using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce.Domain.Interfaces.IModels.IRequestModels;
using eCommerce.Domain.Interfaces.IModels.IResponseModels;

namespace eCommerce.Domain.IServices
{
    public interface IProduktetService
    {
        // Get all products
        Task<IEnumerable<IResponseModels>> GetProduktet();

        // Get product by ID
        Task<IResponseModels> GetProduktById(int id);

        // Create product
        Task<IResponseModels> CreateProdukt(IRequestModels produktRequest);

        // Update product
        Task UpdateProdukt(IRequestModels produktRequest);

        // Delete product
        Task DeleteProdukt(int id);
    }
}
