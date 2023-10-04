using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class AddOrderService : IAddOrderInputHandler
{
    public Task<bool> AddOrderAsync(PostOrderData data)
    {
        throw new NotImplementedException();
    }
}

