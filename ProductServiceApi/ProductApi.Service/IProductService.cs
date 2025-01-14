using ProductServiceApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApi.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetPaginatedProducts(int pageNumber, int pageSize);
        Task<int> GetTotalProductCount();
    }
}