using NightFlyer.UseCases.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DataModels
{
    public record Item
    {
        public Item(Entities.Entities.Item itemEntity, string id)
        {
            if(id == null)
            {
                this.Id = $"item_{Guid.NewGuid().ToString()}";
            }

            this.Name = itemEntity.Name;
            this.Price = itemEntity.Price;
            this.Seller = itemEntity.Seller;
            this.Brand = itemEntity.Brand;
            this.Status = itemEntity.Status.ToString();
            this.Characteristics = itemEntity.Characteristics;
        }

        public Item(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Price = item.Price;
            this.Seller = item.Seller;
            this.Brand = item.Brand;
            this.Status = item.Status;
            this.Characteristics = item.Characteristics;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Seller { get; set; }

        public string Brand { get; set; }

        public string Status { get; set; }

        public List<string> Characteristics { get; set; }

        public Entities.Entities.Item ToEntity()
        {
            return new Entities.Entities.Item
            {
                Name = this.Name,
                Price = this.Price,
                Seller = this.Seller,
                Brand = this.Brand,
                Status = EnumHelper.GetItemStatusEnumFromString(this.Status),
                Characteristics = this.Characteristics
            };
        }
    }
}
