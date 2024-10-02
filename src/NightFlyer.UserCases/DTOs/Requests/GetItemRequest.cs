using System.Text.Json.Serialization;

namespace NightFlyer.UseCases.DTOs.Requests
{
    public class GetItemRequest
    {
        /// <summary>
        /// Id of the item to be retrieved(Single)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The list of Ids of the items to be retrieved(Many)
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }
    }
}
