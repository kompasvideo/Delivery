using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface IGetAllOrderInputService
    {
        Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data);
    }
}

