using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса для получения заявки по Id
    /// </summary>
    public class GetOrderInputRequest : GetOrderData, InputRequest<object>
    {
    }
}

