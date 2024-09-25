using NightFlyer.UseCases.DTOs.Requests;
using NightFlyer.UseCases.DTOs.Responses;
using NightFlyer.UseCases.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Services
{
    internal class InventoryService : IInventoryService
    {
        public Task<CreateItemResponse> CreateItemsAsync(CreateItemRequest request)
        {
            throw new NotImplementedException();
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
