using NightFlyer.Entities.Entities;
using NightFlyer.UseCases.DTOs.Requests;
using NightFlyer.UseCases.DTOs.Responses;
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
        public Item() { }

        public Item(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Price = item.Price;
            this.SellerId = item.SellerId;
            this.Brand = item.Brand;
            this.Status = item.Status;
            this.Characteristics = item.Characteristics;
        }

        public Item(CreateItemRequest request)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = request.Name;
            this.Price = request.Price;
            this.SellerId= request.SellerId;
            this.Brand = request.Brand;
            this.Status = request.Status;
            this.Characteristics = request.Characteristics;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string SellerId { get; set; }

        public string Brand { get; set; }

        public string Status { get; set; }

        public List<string> Characteristics { get; set; }

        public Entities.Entities.ItemEntity ToEntity()
        {
            return new Entities.Entities.ItemEntity
            {
                Name = this.Name,
                Price = this.Price,
                Seller = this.SellerId,
                Brand = this.Brand,
                Status = EnumHelper.GetItemStatusEnumFromString(this.Status),
                Characteristics = this.Characteristics
            };
        }

        public static Item FromEntity(Entities.Entities.ItemEntity itemEntity, string id = null)
        {
            return new Item
            {
                Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                Name = itemEntity.Name,
                Price = itemEntity.Price,
                SellerId = itemEntity.Seller,
                Brand = itemEntity.Brand,
                Status = itemEntity.Status.ToString(),
                Characteristics = itemEntity.Characteristics
            };
        }
    }
}
