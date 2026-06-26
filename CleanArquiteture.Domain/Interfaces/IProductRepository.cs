using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquiteture.Domain.Entities;

namespace CleanArquiteture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(int id);
    
    }
}