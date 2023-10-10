using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-команду для регистрации новой заявки
/// </summary>
public class OrderCanceledSaveInputService : IOrderCanceledSaveInputService
{
    private readonly ICommandHandler<OrderCanceledSaveCommand, bool> _Handler;

    public OrderCanceledSaveInputService(ICommandHandler<OrderCanceledSaveCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> OrderCanceledSaveAsync(OrderCanceledSaveData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

