using Microsoft.EntityFrameworkCore;
using NightFlyer.UseCases.DataModels;

namespace NightFlyer.Adapters.Infrastructure.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ItemCategory> itemCategories { get; set; }
    }
}
