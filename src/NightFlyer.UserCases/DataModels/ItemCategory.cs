using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DataModels
{
    public record ItemCategory
    {
        public ItemCategory() { }

        public ItemCategory(string itemId, string categoryId)
        {
            this.ItemId = itemId;
            this.CategoryId = categoryId;
        }

        public string Id { get; set; }

        public string ItemId { get; set; }

        public string CategoryId {  get; set; } 
    }
}
