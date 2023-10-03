using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Drive
{
    public class InputHandlerPage
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public bool hasPreviousPage { get; set; }
        public bool hasNextPage { get; set; }

        public int TotalPages { get { return PageSize > 0 ? (int)Math.Ceiling(Count / (double)PageSize) : 1; } }

        [JsonIgnore]
        public int Count { get; set; }

    }
}
