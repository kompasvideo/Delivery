using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class AddOrderInputService : IAddOrderInputService
{
    private readonly ICommandHandler<AddOrderCommand, bool> _Handler;

    public AddOrderInputService(ICommandHandler<AddOrderCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> AddOrderAsync(AddOrderData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

