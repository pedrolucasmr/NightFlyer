using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;
using NightFlyer.UseCases.Wrappers.Interfaces;

namespace NightFlyer.UseCases.Wrappers
{
    internal class ItemCategoryWrapper : IItemCategoryWrapper
    {
        public IItemRepository ItemRepository { get; private set; }

        public ICategoryRepository CategoryRepository { get; private set; }

        public IItemCategoriesRepository ItemCategoriesRepository { get; private set; }

        internal ItemCategoryWrapper(IItemRepository itemRepository, ICategoryRepository categoryRepository, IItemCategoriesRepository itemCategoriesRepository)
        {
            ItemRepository = itemRepository;
            CategoryRepository = categoryRepository;
            ItemCategoriesRepository = itemCategoriesRepository;
        }

        public Task InsertItemsAndCategoriesAsync(List<Item> items, List<Category> categories)
        {
            throw new NotImplementedException();
        }

        public async Task InsertItemCategoriesAsync(Item item, List<Category> categories, List<Category> newCategories = null)
        {
            var values = new List<ItemCategory>();

            foreach(var category in categories)
            {
                var newValue = new ItemCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    CategoryId = category.Id,
                    ItemId = item.Id
                };

                values.Add(newValue);
            }

            if(newCategories is not null && newCategories.Any())
            {
                foreach (var category in newCategories)
                {
                    var newValue = new ItemCategory
                    {
                        Id = Guid.NewGuid().ToString(),
                        CategoryId = category.Id,
                        ItemId = item.Id
                    };

                    values.Add(newValue);
                }
            }

            await ItemCategoriesRepository.InsertManyItemCategoriesAsync(values);
        }
    }
}
