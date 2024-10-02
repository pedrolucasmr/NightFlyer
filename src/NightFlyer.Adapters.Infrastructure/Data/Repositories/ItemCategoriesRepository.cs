using Microsoft.EntityFrameworkCore;
using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;

namespace NightFlyer.Adapters.Infrastructure.Data.Repositories
{
    class ItemCategoriesRepository : IItemCategoriesRepository
    {
        private readonly ApiDbContext _dbContext;

        public ItemCategoriesRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteItemCategoryByIdAsync(string id)
        {
            try
            {
                var itemCategory = await GetItemCategoryByIdAsync(id);

                if (itemCategory != null)
                {
                    _dbContext.Items.Remove(itemCategory);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task DeleteManyItemCategoriesByIdAsync(List<string> ids)
        {
            try
            {
                var itemCategories = await GetManyItemCategoriesByIdAsync(ids);

                if (itemCategories != null && itemCategories.Count > 0)
                {
                    _dbContext.itemCategories.RemoveRange(itemCategories);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<ItemCategory> GetItemCategoryByIdAsync(string id)
        {
            try
            {
                return await _dbContext.itemCategories.FirstOrDefaultAsync(i => i.Id == id);
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<List<ItemCategory>> GetManyItemCategoriesByIdAsync(List<string> ids)
        {
            try
            {
                return await _dbContext.itemCategories.Where(i => ids.Contains(i.Id)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertItemCategoryAsync(ItemCategory item)
        {
            try
            {
                _dbContext.itemCategories.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertManyItemCategoriesAsync(List<ItemCategory> items)
        {
            try
            {
                _dbContext.itemCategories.AddRange(items);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task UpdateItemCategoryByIdAsync(ItemCategory newItem)
        {
            try
            {
                var currentItem = await GetItemCategoryByIdAsync(newItem.Id);

                if (currentItem == null)
                    throw new Exception($"Cannot Update a inexisting Item Category. Id {newItem.Id} Not Found"); //TODO: Change this to a Infrastructure Exception

                currentItem = new ItemCategory(newItem);

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }
    }
}
