using CleanArquiteture.Domain.Entities;
using CleanArquiteture.Domain.Interfaces;
using CleanArquiteture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArquiteture.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _productContext;

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetProductAsync(int id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _productContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }

        public async Task<Product> RemoveAsync(int id)
        {
            Product product = await _productContext.Products.FindAsync(id);
            _productContext.Remove(product);
            _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
