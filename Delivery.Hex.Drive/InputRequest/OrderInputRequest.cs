using System;
namespace Delivery.Hex.Drive.InputRequest
{
	public class OrderInputRequest: InputRequest<bool>
	{
		public string DeparturePoint { get; set; }
		public string Destination { get; set; }
		public DateTime Date { get; set; }
	}
}

