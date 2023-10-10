using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно класс-команду для редактирования заявки
    /// </summary>
    public interface IEditOrderInputService
    {
        Task<bool> EditOrderAsync(EditOrderData data);
    }
}

