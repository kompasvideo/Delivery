﻿using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;

/// <summary>
/// класс-сервис вызывает непосредственно класс-команду для редактирования заявки
/// </summary>
public class EditOrderInputService : IEditOrderInputService
{
    private readonly ICommandHandler<EditOrderCommand, bool> _Handler;
    public EditOrderInputService(ICommandHandler<EditOrderCommand, bool> handler)
    {
        _Handler = handler;
    }
    public async Task<bool> EditOrderAsync(EditOrderData data)
    {
        return await _Handler.ExecuteAsync(data);
    }
}

