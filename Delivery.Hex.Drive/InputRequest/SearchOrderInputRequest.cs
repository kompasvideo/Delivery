using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса для поиска текста во всех полях заявки
    /// </summary>
    public class SearchOrderInputRequest : SearchOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

