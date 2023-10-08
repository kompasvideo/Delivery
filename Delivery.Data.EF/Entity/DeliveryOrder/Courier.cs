using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
    public class Courier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourierId { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }
    }
}
