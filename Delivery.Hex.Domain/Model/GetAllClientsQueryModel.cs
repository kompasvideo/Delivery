namespace Delivery.Hex.Domain.Model
{
    /// <summary>
    /// выходные данные для класс-запроса получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public class GetAllClientsQueryModel
    {
        public IEnumerable<object> Clients { get; set; }
    }
}
