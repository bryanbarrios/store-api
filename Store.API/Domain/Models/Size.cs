using System.Collections.Generic;

namespace Store.API.Domain.Models
{
    class Size
    {
        private Type Type { get; set; }
        private List<string> AvailableSizes { get; set; }
    }
}