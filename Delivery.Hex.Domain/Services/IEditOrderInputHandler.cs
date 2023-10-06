using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface IEditOrderInputService
    {
        Task<bool> EditOrderAsync(EditOrderData data);
    }
}

