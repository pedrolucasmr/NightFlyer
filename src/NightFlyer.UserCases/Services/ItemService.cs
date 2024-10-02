using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.DTOs.Requests;
using NightFlyer.UseCases.DTOs.Responses;
using NightFlyer.UseCases.Services.Interfaces;
using NightFlyer.UseCases.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var category = _itemCategoryWrapper.CategoryRepository.GetManyCategoriesByIdAsync(request.Categories);
            var dataModel = new Item(request);

            return new CreateItemResponse();
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
    }
}
