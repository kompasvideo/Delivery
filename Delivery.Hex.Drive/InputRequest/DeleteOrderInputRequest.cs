using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса удаления заявки
    /// </summary>
    public class DeleteOrderInputRequest : DeleteOrderData, InputRequest<bool>
    {
    }
}

