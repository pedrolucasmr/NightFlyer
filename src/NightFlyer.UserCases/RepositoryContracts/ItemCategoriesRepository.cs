using NightFlyer.UseCases.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.RepositoryContracts
{
    public interface ItemCategoriesRepository
    {
        Task InsertItemCategoryAsync(ItemCategory item);

        Task InsertManyItemCategoriesAsync(List<ItemCategory> items);

        Task UpdateItemCategoryByIdAsync(ItemCategory newItem);

        Task<Item> GetItemCategoryByIdAsync(string id);

        Task<List<Item>> GetManyItemCategoriesByIdAsync(List<string> ids);

        Task DeleteItemCategoryByIdAsync(string id);

        Task DeleteManyItemCategoriesByIdAsync(List<string> ids);
    }
}
