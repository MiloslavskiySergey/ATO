using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Order
	{
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string Mesto { get; set; } = default!;

		[Required, StringLength(6)]
		public int Counts { get; set; }

		[Required]
		public int FlightId { get; set; }
		public Flight Flight { get; set; } = default!;

		[Required]
		public int ClientId { get; set; }
		public Client Client { get; set; } = default!;

		[Required]
		public int CardId { get; set; }
		public Card Card { get; set; } = default!;
	}
}
