using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IGetOrderInputService
    {
        Task<object> GetOrderAsync(GetOrderData data);
    }
}

