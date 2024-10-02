using NightFlyer.Entities.Enums;

namespace NightFlyer.Entities.Entities
{
    public class ItemEntity
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Seller { get; set; }

        public string Brand { get; set; }

        public ItemStatusEnum Status { get; set; }

        public List<string> Characteristics { get; set; }

        public List<CategoryEntity> Categories { get; set; }

        public bool MatchCharacteristic(string characteristic)
        {
            return Characteristics.Contains(characteristic);
        }
    }
}
