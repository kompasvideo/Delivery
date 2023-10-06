using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface IAddOrderInputService
    {
        Task<bool> AddOrderAsync(AddOrderData data);
    }
}

