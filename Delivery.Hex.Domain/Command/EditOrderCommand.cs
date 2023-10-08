namespace Delivery.Hex.Domain.Command
{
    public class EditOrderCommand : ICommand<bool>
    {
        public int OrderId { get; set; }
        /// <summary>
        /// дата
        /// </summary>
        public string? Date { get; set; }
        /// <summary>
        /// грузоотправитель
        /// </summary>
        public string Shipper { get; set; }
        /// <summary>
        /// грузополучатель
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// груз
        /// </summary>
        public string? Cargo { get; set; }
        //public StatusOrder StatusOrder { get; set; }
        public int? CourierInfoKey { get; set; }
        //public Courier Courier { get; set; }
    }
}
