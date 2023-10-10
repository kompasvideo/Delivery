namespace Delivery.Hex.Domain.Model
{
    /// <summary>
    /// выходные данные для класс-запроса получения заявки по Id
    /// </summary>
    public class GetOrderQueryModel
    {
        public object Order { get; set; }
    }
}
