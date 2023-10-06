using System;
namespace Delivery.Hex.Drive.InputRequest
{
	public class AddOrderInputRequest: InputRequest<bool>
	{
        public int OrderId { get; set; }
        /// <summary>
        /// дата
        /// </summary>
        public string? Date { get; set; }
        /// <summary>
        /// грузоотправитель
        /// </summary>
        public string? Shipper { get; set; }
        /// <summary>
        /// грузополучатель
        /// </summary>
        public string? Consignee { get; set; }
        /// <summary>
        /// груз
        /// </summary>
        public string? Cargo { get; set; }
        public bool NewOrder { get; set; }
    }
}

