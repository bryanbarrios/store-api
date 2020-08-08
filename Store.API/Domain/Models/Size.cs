using System.Collections.Generic;

namespace Store.API.Domain.Models
{
    public class Size
    {
        public Type Type { get; set; }
        public List<string> AvailableSizes { get; set; }
    }
}