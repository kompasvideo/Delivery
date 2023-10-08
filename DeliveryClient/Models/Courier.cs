using Newtonsoft.Json;

namespace DeliveryClient.Models
{
    public class Courier
    {
        public int CourierId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Order> Order { get; set; }
    }
}
