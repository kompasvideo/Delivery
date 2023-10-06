using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface IDeleteOrderInputService
    {
        Task<bool> DeleteOrderAsync(DeleteOrderData data);
    }
}

