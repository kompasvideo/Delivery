using System;
namespace Delivery.Hex.Domain.Command
{
	public class PostOrderData : ICommand<bool>
	{
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

