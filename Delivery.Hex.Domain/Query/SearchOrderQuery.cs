using Delivery.Hex.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Domain.Query
{
    public class SearchOrderQuery : IQuery<SearchOrderQueryModel>
    {
        public string Text { get; set; }
    }
}
