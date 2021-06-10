using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Route
	{
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string Start { get; set; } = default!;

		[Required, StringLength(30)]
		public string Target { get; set; } = default!;

		[Required, StringLength(10)]
		public decimal Price { get; set; }

		[Required, StringLength(5)]
		public int Time { get; set; }


		public ICollection<Flight> Flights { get; set; } = new List<Flight>();

	}
}
