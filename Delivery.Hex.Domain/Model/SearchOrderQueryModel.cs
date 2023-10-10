namespace Delivery.Hex.Domain.Model
{
    /// <summary>
    /// выходные данные для класс-запроса поиск текста в полях заявки
    /// </summary>
    public class SearchOrderQueryModel
    {
        public IEnumerable<object> Orders { get; set; }
    }
}
