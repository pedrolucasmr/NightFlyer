using System.Text.Json.Serialization;

namespace NightFlyer.UseCases.DTOs.Requests
{
    internal class CreateCategoryRequest
    {
        /// <summary>
        /// Name of the category
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the category
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
