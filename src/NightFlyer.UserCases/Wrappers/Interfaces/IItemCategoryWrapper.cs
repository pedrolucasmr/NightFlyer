using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;

namespace NightFlyer.UseCases.Wrappers.Interfaces
{
    internal interface IItemCategoryWrapper
    {
        IItemRepository ItemRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        Task InsertItemsAndCategoriesAsync(List<Item> items, List<Category> categories);

        Task InsertItemCategoriesAsync(Item item, List<Category> categories, List<Category> newCategories);
    }
}
