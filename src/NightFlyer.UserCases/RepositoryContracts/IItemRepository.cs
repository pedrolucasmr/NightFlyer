using NightFlyer.UseCases.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
