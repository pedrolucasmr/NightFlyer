using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NightFlyer.UseCases.DTOs.Requests
{
    public class CreateItemRequest
    {
        /// <summary>
        /// Name of the item
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Price of the item
        /// </summary>
        [Required]
        [JsonPropertyName("price")]
        public int Price { get; set; }

        /// <summary>
        /// Id of the seller responsible for the item
        /// </summary>
        [Required]
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// Brand name of the item
        /// </summary>
        [Required]
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Current Status of the item
        /// </summary>
        [Required]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// A List of ids of categories of the item
        /// </summary>
        [Required]
        [JsonPropertyName("status")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// A List of characteristics of the item
        /// </summary>
        [Required]
        [JsonPropertyName("characteristics")]
        public List<string> Characteristics { get; set; }
    }
}
