using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно класс-команду для удаления заявки
    /// </summary>
    public interface IDeleteOrderInputService
    {
        Task<bool> DeleteOrderAsync(DeleteOrderData data);
    }
}

