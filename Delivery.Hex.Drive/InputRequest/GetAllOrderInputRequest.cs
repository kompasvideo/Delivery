using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса для получения всех заявок
    /// </summary>
    public class GetAllOrderInputRequest : GetAllOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

