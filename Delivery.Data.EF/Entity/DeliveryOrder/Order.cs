using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
    /// <summary>
    /// класс описывает таблицу заявак
    /// </summary>
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        /// <summary>
        /// дата
        /// </summary>
        public string? Date { get; set; }
        public int? ShipperInfoKey { get; set; }
        /// <summary>
        /// грузоотправитель
        /// </summary>
        [ForeignKey("ShipperInfoKey")]
        public Client Shipper { get; set; }
        public int? ConsigneeInfoKey { get; set; }
        /// <summary>
        /// грузополучатель
        /// </summary>
        [ForeignKey("ConsigneeInfoKey")]
        public Client Consignee { get; set; }
        /// <summary>
        /// название груза
        /// </summary>
        public string? Cargo { get; set; }
        /// <summary>
        /// статус заявки
        /// </summary>
        public StatusOrder StatusOrder { get; set; }

        /// <summary>
        /// связь с таблицей курьеров
        /// </summary>
        [MaybeNull]
        public int? CourierInfoKey { get; set; }
        [MaybeNull]
        [ForeignKey("CourierInfoKey")]
        public Courier Courier { get; set; }
        /// <summary>
        /// Комментарий к отмене заявке
        /// </summary>
        public string? Comments { get; set; }
    }
}

