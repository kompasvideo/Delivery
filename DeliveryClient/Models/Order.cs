using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DeliveryClient.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        /// <summary>
        /// дата
        /// </summary>
        public string? Date { get; set; }
        public int? ShipperInfoKey { get; set; }
        /// <summary>
        /// грузоотправитель
        /// </summary>
        public Client Shipper { get; set; }
        public int? ConsigneeInfoKey { get; set; }
        /// <summary>
        /// грузополучатель
        /// </summary>
        public Client Consignee { get; set; }
        /// <summary>
        /// груз
        /// </summary>
        public string? Cargo { get; set; }
        public StatusOrder StatusOrder { get; set; }
        public int? CourierInfoKey { get; set; }
        public Courier Courier { get; set; }
        /// <summary>
        /// Комментарий к отмене заявке
        /// </summary>
        public string? Comments { get; set; }
    }
}
