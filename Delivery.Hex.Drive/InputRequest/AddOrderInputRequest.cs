using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса регистрации новой заявки
    /// </summary>
    public class AddOrderInputRequest : AddOrderData, InputRequest<bool>
    {
    }
}

