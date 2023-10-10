namespace Delivery.Hex.Domain.Model
{
    /// <summary>
    /// выходные данные для класс-запроса получения всех заявок
    /// </summary>
    public class GetAllQueryModel
    {
        public IEnumerable<object> Orders { get; set; }
    }
}
