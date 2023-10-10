using Delivery.Hex.Domain.Entity;

namespace Delivery.Hex.Domain.Services
{
    /// <summary>
    /// интерфейс для класс-сервис который вызывает непосредственно класс-запрос для поиска текста в полях заявки
    /// </summary>
    public interface ISearchOrderInputService
    {
        Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data);
    }
}

