using CleanArquiteture.Domain.Entities;
using CleanArquiteture.Domain.Interfaces;
using CleanArquiteture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArquiteture.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;

        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;    
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _categoryContext.Categories.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }

        public async Task<Category> RemoveAsync(int id)
        {
            Category category = await _categoryContext.Categories.FindAsync(id);
            _categoryContext.Remove(category);
            _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _categoryContext.Update(category);
            _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}
