using Microsoft.EntityFrameworkCore;
using ProductServiceApi.Data;
using ProductServiceApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetPaginatedProducts(int pageNumber, int pageSize)
        {
            if (pageNumber < 1) pageNumber = 1;
            if (pageSize < 1) pageSize = 3;  // Set default pageSize if it's 0

            // Skip records for previous pages, and take only the current page's size of records
            return await _context.Products
                .Skip((pageNumber - 1) * pageSize)  
                .Take(pageSize)                    
                .ToListAsync();
        }

        public async Task<int> GetTotalProductCount()
        {
            return await _context.Products.CountAsync();
        }
    }
}
