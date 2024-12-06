using NightFlyer.UseCases.DataModels;
using NightFlyer.UseCases.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Mappers
{
    internal static class CreateItemResponseMapper
    {
        internal static CreateItemResponse MapFromDataModel(Item item, List<Category> categories, List<Category> newCategories = null)
        {
            var response = new CreateItemResponse()
            {
                CreatedSuccessfully = true,
                ItemResponse = new ItemResponse()
                {
                    Id = item.Id,
                    SellerId = item.SellerId,
                    Name = item.Name,
                    Status = item.Status
                }
            };

            response.ItemResponse.Categories = new List<CategoryResponse>();

            foreach(var category in categories)
            {
                var categoryResponse = new CategoryResponse()
                {
                    Id = category.Id,
                    Name = category.Name
                };

                response.ItemResponse.Categories.Add(categoryResponse);
            }

            if(newCategories is not null && newCategories.Any())
            {
                foreach (var category in newCategories)
                {
                    var categoryResponse = new CategoryResponse()
                    {
                        Id = category.Id,
                        Name = category.Name
                    };

                    response.ItemResponse.Categories.Add(categoryResponse);
                }
            }

            return response;
        }

        internal static CreateItemResponse MapError(string errorMessage, string errorCode)
        {
            var response = new CreateItemResponse()
            {
                CreatedSuccessfully = false,
                ErrorContent = new ErrorResponse()
                {
                    ErrorCode = errorCode,
                    ErrorMessage = errorMessage
                }
            };

            return response;
        }
    }
}
