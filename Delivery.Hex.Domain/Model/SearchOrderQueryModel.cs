using Delivery.Data.EF.Entity.DeliveryOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Domain.Model
{
    public class SearchOrderQueryModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
