using Microsoft.EntityFrameworkCore;
using NightFlyer.UseCases.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.Adapters.Infrastructure.Data
{
    internal class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
