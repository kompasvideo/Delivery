using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-команду для регистрации новой заявки
/// </summary>
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

