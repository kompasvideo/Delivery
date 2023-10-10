namespace DeliveryClient.Models
{
    public class ViewTransfer
    {
        public Order Order { get; set; }
        public IEnumerable<Courier> Couriers { get; set; }
    }
}
