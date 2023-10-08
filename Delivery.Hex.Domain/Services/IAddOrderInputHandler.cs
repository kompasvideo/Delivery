using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IAddOrderInputService
    {
        Task<bool> AddOrderAsync(AddOrderData data);
    }
}

