using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.Entities.Entities
{
    public class Item
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Seller { get; set; }

        public string Brand { get; set; }

        public List<string> Characteristics { get; set; }

        public bool MatchCharacteristic(string characteristic)
        {
            return Characteristics.Contains(characteristic);
        }
    }
}
