using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DTOs.Requests
{
    public class UpdateItemRequest
    {
        /// <summary>
        /// Id of the item
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Price of the item
        /// </summary>
        [JsonPropertyName("price")]
        public int Price { get; set; }

        /// <summary>
        /// Id of the seller responsible for the item
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// Brand name of the item
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Current Status of the item
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// A List of characteristics of the item
        /// </summary>
        [JsonPropertyName("characteristics")]
        public List<string> Characteristics { get; set; }
    }
}
