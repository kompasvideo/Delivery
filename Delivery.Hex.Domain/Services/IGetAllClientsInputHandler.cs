using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface IGetAllClientsInputService
    {
        Task<IEnumerable<object>> GetAllClientsAsync(GetAllClientsData data);
    }
}

