﻿using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно класс-команду для регистрации новой заявки
    /// </summary>
    public interface IOrderDoneInputService
    {
        Task<bool> OrderDoneAsync(OrderDoneData data);
    }
}

