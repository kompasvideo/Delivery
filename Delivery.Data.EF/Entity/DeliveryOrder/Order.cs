using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
	[Table("Order", Schema = "order")]
	public class Order
	{
        [Key]
        public int OrderId { get; set; }
		public DateTime Date { get; set; }
		/// <summary>
		/// грузоотправитель
		/// </summary>
		public string Shipper { get; set; }
		/// <summary>
		/// грузополучатель
		/// </summary>
		public string Consignee { get; set; }
		public string Cargo { get; set; }
	}
}

