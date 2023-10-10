using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса редактирования заявки
    /// </summary>
    public class EditOrderInputRequest : EditOrderData, InputRequest<bool>
    {
    }
}

