using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.DTOs.Responses
{
    public record CreateCategoryResponse
    {
        public bool CreatedSuccessfully { get; set; }

        public string? ErrorMessage { get; set; }
    }

    public record CategoryResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
