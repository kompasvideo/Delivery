using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    public interface ISearchOrderInputService
    {
        Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data);
    }
}

