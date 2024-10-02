using NightFlyer.UseCases.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Wrappers.Interfaces
{
    internal interface IItemCategoryWrapper
    {
        IItemRepository ItemRepository { get; }
        ICategoryRepository CategoryRepository { get; }
    }
}
