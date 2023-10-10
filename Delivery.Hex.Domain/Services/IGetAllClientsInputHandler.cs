using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервиса который вызывает непосредственно 
    /// класс-запрос для получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public interface IGetAllClientsInputService
    {
        Task<IEnumerable<object>> GetAllClientsAsync(GetAllClientsData data);
    }
}

