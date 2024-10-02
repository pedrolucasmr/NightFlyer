using NightFlyer.UseCases.DTOs.Requests;
using NightFlyer.UseCases.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Services.Interfaces
{
    public interface IItemService
    {
        Task<CreateItemResponse> CreateItemsAsync(CreateItemRequest request);

        Task<GetItemResponse> GetItemsAsync(GetItemRequest request);

        Task<UpdateItemResponse> UpdateItemsAsync(UpdateItemRequest request);

        Task<DeleteItemResponse> DeleteItemsAsync(DeleteItemRequest request);
    }
}
