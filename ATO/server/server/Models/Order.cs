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
		[Required]

		public string Mesto { get; set; } = default!;
		[Required, StringLength(30)]

		public int Counts { get; set; } = default!;
		[Required, StringLength(6)]

		public int Flight_id { get; set; }
		[Required]
		public Flight Flight { get; set; } = default!;

		public int Client_id { get; set; }
		[Required]
		public Client Client { get; set; } = default!;

		public int Card_id { get; set; }
		[Required]
		public Card Card { get; set; } = default!;
	}
}
