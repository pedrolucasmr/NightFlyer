using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DataModels
{
    internal record ItemCategory
    {
        public ItemCategory(string itemId, string categoryId)
        {
            this.ItemId = itemId;
            this.CategoryId = categoryId;
        }

        public string ItemId { get; set; }

        public string CategoryId {  get; set; } 
    }
}
