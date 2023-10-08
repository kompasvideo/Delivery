using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class DeleteOrderInputService : IDeleteOrderInputService
{
    private readonly ICommandHandler<DeleteOrderCommand, bool> _Handler;
    public DeleteOrderInputService(ICommandHandler<DeleteOrderCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> DeleteOrderAsync(DeleteOrderData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

