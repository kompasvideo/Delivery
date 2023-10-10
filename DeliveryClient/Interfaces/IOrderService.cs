using DeliveryClient.Models;

namespace DeliveryClient.Interfaces
{
    /// <summary>
    /// Интерфейс для класса-сервиса
    /// </summary>
    public interface IOrderService
    {
        IEnumerable<Order> Orders { get; set; }
        IEnumerable<Order> GetAll();
        void DeleteOrder(int id);
        Task SaveOrder(Order order);
        IEnumerable<Order> SearchOrder(string text);
        Order GetOrderById(int id);
        Task EditOrder(Order order);
        IEnumerable<Client> GetClients();
        Client GetClientToName(string name);
        IEnumerable<Courier> GetCouriers();
        Task TransferOrderSave(int id, string courier);
        Task OrderDone(int id);
        Task OrderCanceledSave(int id, string comments);
    }
}
