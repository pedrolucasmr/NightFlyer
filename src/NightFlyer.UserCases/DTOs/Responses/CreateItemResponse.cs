using System.Runtime.CompilerServices;

namespace NightFlyer.UseCases.DTOs.Responses
{
    public record CreateItemResponse
    {
        public bool CreatedSuccessfully { get; set; }

        public ErrorResponse? ErrorContent { get; set; }

        public ItemResponse ItemResponse { get; set; }
    }

    public record ItemResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string SellerId { get; set; }

        public string Status { get; set; }

        public List<CategoryResponse> Categories { get; set; }
    }
}
