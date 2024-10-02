using NightFlyer.UseCases.DataModels;

namespace NightFlyer.UseCases.RepositoryContracts
{
    public interface IItemRepository
    {
        Task InsertItemAsync(Item item);

        Task InsertManyItemsAsync(List<Item> items);

        Task UpdateItemByIdAsync(Item newItem);

        Task<Item> GetItemByIdAsync(string id);

        Task<List<Item>> GetManyItemsByIdAsync(List<string> ids);

        Task DeleteItemByIdAsync(string id);

        Task DeleteManyItemsByIdAsync(List<string> ids);
    }
}
