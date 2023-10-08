using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IDeleteOrderInputService
    {
        Task<bool> DeleteOrderAsync(DeleteOrderData data);
    }
}

