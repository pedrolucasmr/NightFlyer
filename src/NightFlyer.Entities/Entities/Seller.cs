using NightFlyer.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.Entities.Entities
{
    public class Seller
    {
        public string Name { get; set; }

        public SellerStatusEnum Status { get; set; }
    }
}
