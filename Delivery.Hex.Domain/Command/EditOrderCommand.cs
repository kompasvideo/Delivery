namespace Delivery.Hex.Domain.Command
{
    /// <summary>
    /// данные для класс-команды для редактирования заявки 
    /// </summary>
    public class EditOrderCommand : ICommand<bool>
    {
        public int OrderId { get; set; }
        /// <summary>
        /// дата
        /// </summary>
        public string? Date { get; set; }
        public int? ShipperInfoKey { get; set; }
        ///// <summary>
        ///// грузоотправитель
        ///// </summary>
        public string? Shipper { get; set; }
        public int? ConsigneeInfoKey { get; set; }
        ///// <summary>
        ///// грузополучатель
        ///// </summary>
        public string? Consignee { get; set; }
        ///// <summary>
        ///// груз
        ///// </summary>
        public string? Cargo { get; set; }
        public int StatusOrder { get; set; }
        public int CourierInfoKey { get; set; }
        public string? Courier { get; set; }
        /// <summary>
        /// Комментарий к отмене заявке
        /// </summary>
        public string? Comments { get; set; }
    }
}
