using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно класс-запрос для получения заявки по id
    /// </summary>
    public interface IGetOrderInputService
    {
        Task<object> GetOrderAsync(GetOrderData data);
    }
}

