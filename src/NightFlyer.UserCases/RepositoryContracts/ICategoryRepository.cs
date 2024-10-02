using NightFlyer.UseCases.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.RepositoryContracts
{
    public interface ICategoryRepository
    {
        Task InsertCategoryAsync(Category item);

        Task InsertManyCategoriesAsync(List<Category> items);

        Task UpdateCategoryByIdAsync(Category newItem);

        Task<Category> GetCategoryByIdAsync(string id);

        Task<List<Category>> GetManyCategoriesByIdAsync(List<string> ids);

        Task DeleteCategoryByIdAsync(string id);

        Task DeleteManyCategoriesByIdAsync(List<string> ids);
    }
}
