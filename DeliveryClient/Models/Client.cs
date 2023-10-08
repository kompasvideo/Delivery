namespace DeliveryClient.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }
        public List<Order> Order2 { get; set; }
    }
}
