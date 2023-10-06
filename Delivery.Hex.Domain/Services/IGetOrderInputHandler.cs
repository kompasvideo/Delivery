using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface IGetOrderInputService
    {
        Task<object> GetOrderAsync(GetOrderData data);
    }
}

