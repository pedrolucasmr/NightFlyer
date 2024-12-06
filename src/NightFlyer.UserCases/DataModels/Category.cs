using NightFlyer.UseCases.DTOs.Requests;

namespace NightFlyer.UseCases.DataModels
{
    public record Category
    {
        public Category() { }

        public Category(Category category)
        {
            this.Id = category.Id;
            this.Description = category.Description;
            this.Name = category.Name;
        }

        public Category(CreateCategoryRequest createCategoryRequest)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = createCategoryRequest.Name;
            this.Description = createCategoryRequest.Description;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Entities.Entities.CategoryEntity ToEntity()
        {
            return new Entities.Entities.CategoryEntity
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }

        public Category FromEntity(Entities.Entities.CategoryEntity categoryEntity, string id)
        {
            return new Category()
            {
                Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                Name = categoryEntity.Name,
                Description = categoryEntity.Description
            };
        }
    }
}
