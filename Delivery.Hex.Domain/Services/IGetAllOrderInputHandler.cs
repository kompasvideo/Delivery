using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IGetAllOrderInputService
    {
        Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data);
    }
}

