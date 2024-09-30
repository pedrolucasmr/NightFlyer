using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DataModels
{
    public record Category
    {
        public Category() { }

        public Category(Entities.Entities.Category categoryEntity)
        {
            this.Id = categoryEntity.Id;
            this.Name = categoryEntity.Name;
            this.Description = categoryEntity.Description;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Entities.Entities.Category ToEntity()
        {
            return new Entities.Entities.Category
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }
    }
}
