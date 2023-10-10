using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно класс-запрос для получения всех заявок
    /// </summary>
    public interface IGetAllCouriersInputService
    {
        Task<IEnumerable<object>> GetAllCouriersAsync(GetAllCouriersData data);
    }
}

