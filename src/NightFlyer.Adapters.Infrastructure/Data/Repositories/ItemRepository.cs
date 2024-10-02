using Microsoft.EntityFrameworkCore;
using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;

namespace NightFlyer.Adapters.Infrastructure.Data.Repositories
{
    internal class ItemRepository : IItemRepository
    {
        private readonly ApiDbContext _dbContext;

        public ItemRepository(ApiDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task DeleteItemByIdAsync(string id)
        {
            try
            {
                var item = await GetItemByIdAsync(id);

                if(item != null)
                {
                    _dbContext.Items.Remove(item);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task DeleteManyItemsByIdAsync(List<string> ids)
        {
            try
            {
                var items = await GetManyItemsByIdAsync(ids);

                if (items != null && items.Count >0)
                {
                    _dbContext.Items.RemoveRange(items);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<Item> GetItemByIdAsync(string id)
        {
            try
            {
                return await _dbContext.Items.FirstOrDefaultAsync(i => i.Id == id);
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task<List<Item>> GetManyItemsByIdAsync(List<string> ids)
        {
            try
            {
                return await _dbContext.Items.Where(i => ids.Contains(i.Id)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertItemAsync(Item item)
        {
            try
            {
                _dbContext.Items.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task InsertManyItemsAsync(List<Item> items)
        {
            try
            {
                _dbContext.Items.AddRange(items);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }

        public async Task UpdateItemByIdAsync(Item newItem)
        {
            try
            {
                var currentItem = await GetItemByIdAsync(newItem.Id);

                if (currentItem == null)
                    throw new Exception($"Cannot Update a inexisting Item. Id {newItem.Id} Not Found"); //TODO: Change this to a Infrastructure Exception

                currentItem = new Item(newItem);

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw; //TODO: Change this to a Infrastructure Exception
            }
        }
    }
}
