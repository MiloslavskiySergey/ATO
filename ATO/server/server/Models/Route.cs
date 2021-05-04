using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Route
	{
		public int id { get; set; }
		[Required]

		public string start { get; set; } = default!;
		[Required, StringLength(30)]

		public string target { get; set; } = default!;
		[Required, StringLength(30)]

		public decimal price { get; set; } = default!;
		[Required, StringLength(10)]

		public int time { get; set; } = default!;
		[Required, StringLength(5)]

		public ICollection<Flight> Flights { get; set; } = new List<Flight>();

	}
}
