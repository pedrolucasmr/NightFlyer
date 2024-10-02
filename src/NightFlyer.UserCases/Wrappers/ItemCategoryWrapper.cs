using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.RepositoryContracts;
using NightFlyer.UseCases.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Wrappers
{
    internal class ItemCategoryWrapper : IItemCategoryWrapper
    {
        public IItemRepository ItemRepository { get; private set; }

        public ICategoryRepository CategoryRepository { get; private set; }

        internal ItemCategoryWrapper(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            ItemRepository = itemRepository;
            CategoryRepository = categoryRepository;
        }

        public Task InsertItemsAndCategoriesAsync(List<Item> items, List<Category> categories)
        {
            throw new NotImplementedException();
        }
    }
}
