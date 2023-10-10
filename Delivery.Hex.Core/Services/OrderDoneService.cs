using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-команду для регистрации новой заявки
/// </summary>
public class OrderDoneInputService : IOrderDoneInputService
{
    private readonly ICommandHandler<OrderDoneCommand, bool> _Handler;

    public OrderDoneInputService(ICommandHandler<OrderDoneCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> OrderDoneAsync(OrderDoneData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

