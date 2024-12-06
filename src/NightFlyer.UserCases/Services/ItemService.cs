using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.DTOs.Requests;
using NightFlyer.UseCases.DTOs.Responses;
using NightFlyer.UseCases.Mappers;
using NightFlyer.UseCases.Services.Interfaces;
using NightFlyer.UseCases.Wrappers.Interfaces;

namespace NightFlyer.UseCases.Services
{
    internal class ItemService : IItemService
    {
        private readonly IItemCategoryWrapper _itemCategoryWrapper;

        public ItemService(IItemCategoryWrapper itemCategoryWrapper)
        {
            _itemCategoryWrapper = itemCategoryWrapper;
        }

        public async Task<CreateItemResponse> CreateItemsAsync(CreateItemRequest request)
        {
            var categories = await _itemCategoryWrapper.CategoryRepository.GetManyCategoriesByIdAsync(request.Categories);
            var newCategories = new List<Category>();

            if (request.NewCategories.Any())
            {
                newCategories = await AddNewCategories(request.NewCategories);
            }

            var itemDataModel = new Item(request);

            await _itemCategoryWrapper.ItemRepository.InsertItemAsync(itemDataModel);

            await _itemCategoryWrapper.InsertItemCategoriesAsync(itemDataModel, categories, newCategories);

            return CreateItemResponseMapper.MapFromDataModel(itemDataModel, categories, newCategories);
        }

        public Task<DeleteItemResponse> DeleteItemsAsync(DeleteItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetItemResponse> GetItemsAsync(GetItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateItemResponse> UpdateItemsAsync(UpdateItemRequest request)
        {
            throw new NotImplementedException();
        }

        private async Task<List<Category>> AddNewCategories(List<CreateCategoryRequest> createCategoryRequests)
        {
            var newCategories = new List<Category>();

            foreach (var newCategory in createCategoryRequests)
            {
                newCategories.Add(new Category(newCategory));
            }

            await _itemCategoryWrapper.CategoryRepository.InsertManyCategoriesAsync(newCategories);

            return newCategories;
        }
    }
}
