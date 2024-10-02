namespace NightFlyer.UseCases.DataModels
{
    public record ItemCategory
    {
        public ItemCategory() { }

        public ItemCategory(string itemId, string categoryId, string id = null)
        {
            if (String.IsNullOrEmpty(id))
                this.Id = Guid.NewGuid().ToString();

            this.ItemId = itemId;
            this.CategoryId = categoryId;
        }

        public ItemCategory(ItemCategory itemCategory)
        {
            this.Id = itemCategory.Id;
            this.CategoryId= itemCategory.CategoryId;
            this.ItemId= itemCategory.ItemId;
        }

        public string Id { get; set; }

        public string ItemId { get; set; }

        public string CategoryId {  get; set; } 
    }
}
