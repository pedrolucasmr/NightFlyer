using NightFlyer.UseCases.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.RepositoryContracts
{
    public interface IItemCategoriesRepository
    {
        Task InsertItemCategoryAsync(ItemCategory item);

        Task InsertManyItemCategoriesAsync(List<ItemCategory> items);

        Task UpdateItemCategoryByIdAsync(ItemCategory newItem);

        Task<ItemCategory> GetItemCategoryByIdAsync(string id);

        Task<List<ItemCategory>> GetManyItemCategoriesByIdAsync(List<string> ids);

        Task DeleteItemCategoryByIdAsync(string id);

        Task DeleteManyItemCategoriesByIdAsync(List<string> ids);
    }
}
