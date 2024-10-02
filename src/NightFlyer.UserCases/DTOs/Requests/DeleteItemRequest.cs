using System.Text.Json.Serialization;

namespace NightFlyer.UseCases.DTOs.Requests
{
    public record DeleteItemRequest
    {
        /// <summary>
        /// Id of the item to be deleted(Single)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The list of Ids of the items to be deleted(Many)
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }
    }
}
