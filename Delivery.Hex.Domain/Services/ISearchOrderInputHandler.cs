using Delivery.Hex.Domain.Data;

namespace Delivery.Hex.Domain.Services
{
    public interface ISearchOrderInputService
    {
        Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data);
    }
}

