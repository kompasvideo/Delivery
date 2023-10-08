using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Order> Order { get; set; }
        [JsonIgnore]
        public List<Order> Order2 { get; set; }
    }
}
