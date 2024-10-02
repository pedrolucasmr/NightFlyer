using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
