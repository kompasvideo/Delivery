using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-команду для регистрации новой заявки
/// </summary>
public class TransferSaveOrderInputService : ITransferSaveOrderInputService
{
    private readonly ICommandHandler<TransferSaveOrderCommand, bool> _Handler;

    public TransferSaveOrderInputService(ICommandHandler<TransferSaveOrderCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> TransferSaveOrderAsync(TransferSaveOrderData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

