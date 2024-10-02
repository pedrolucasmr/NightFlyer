using Microsoft.EntityFrameworkCore;
using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.Adapters.Infrastructure.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApiDbContext _dbContext;

        public CategoryRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteCategoryByIdAsync(string id)
        {
            try
            {
                var category = await GetCategoryByIdAsync(id);

                if (category != null)
                {
                    _dbContext.Categories.Remove(category);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task DeleteManyCategoriesByIdAsync(List<string> ids)
        {
            try
            {
                var categories = await GetManyCategoriesByIdAsync(ids);

                if (categories != null && categories.Count > 0)
                {
                    _dbContext.Categories.RemoveRange(categories);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<Category> GetCategoryByIdAsync(string id)
        {
            try
            {
                return await _dbContext.Categories.FirstOrDefaultAsync(i => i.Id == id);
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<List<Category>> GetManyCategoriesByIdAsync(List<string> ids)
        {
            try
            {
                return await _dbContext.Categories.Where(i => ids.Contains(i.Id)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertCategoryAsync(Category category)
        {
            try
            {
                _dbContext.Categories.Add(category);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertManyCategoriesAsync(List<Category> categories)
        {
            try
            {
                _dbContext.Categories.AddRange(categories);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task UpdateCategoryByIdAsync(Category newCategory)
        {
            try
            {
                var currentItem = await GetCategoryByIdAsync(newCategory.Id);

                if (currentItem == null)
                    throw new Exception($"Cannot Update a inexisting Category. Id {newCategory.Id} Not Found"); //TODO: Change this to a Infrastructure Exception

                currentItem = new Category(newCategory);

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }
    }
}
