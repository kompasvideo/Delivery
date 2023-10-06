using DeliveryClient.Models;

namespace DeliveryClient.Interfaces
{
    public interface IOrder
    {
        IEnumerable<Order> Orders { get; set; }
        IEnumerable<Order> GetAll();
        void DeleteOrder(int id);
        Task SaveOrder(Order order);
        IEnumerable<Order> SearchOrder(string text);
        Order GetOrderById(int id);
        Task EditOrder(Order order);
    }
}
