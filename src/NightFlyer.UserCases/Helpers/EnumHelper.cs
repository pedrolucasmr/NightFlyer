using NightFlyer.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NightFlyer.UseCases.Helpers
{
    internal static class EnumHelper
    {
        private static Dictionary<string, ItemStatusEnum> itemStatusDict = new Dictionary<string, ItemStatusEnum>()
        {
            { "Undefined", ItemStatusEnum.Undefined },
            { "Active", ItemStatusEnum.Active },
            { "Inactive", ItemStatusEnum.Inactive }
        };

        internal static ItemStatusEnum GetItemStatusEnumFromString(string status)
        {
            var isSuccess = itemStatusDict.TryGetValue(status, out var result);

            if (!isSuccess)
                throw new Exception($"Invalid status found during mapping: {status}"); //TODO: change this to a use case exception

            return result;
        }
    }
}
