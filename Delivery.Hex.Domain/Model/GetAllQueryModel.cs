using Delivery.Data.EF.Entity.DeliveryOrder;

namespace Delivery.Hex.Domain.Model
{
    public class GetAllQueryModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
