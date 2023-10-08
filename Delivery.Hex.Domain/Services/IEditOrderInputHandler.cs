using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IEditOrderInputService
    {
        Task<bool> EditOrderAsync(EditOrderData data);
    }
}

