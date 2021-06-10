using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Card
	{
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string Name { get; set; } = default!;

		[Required, StringLength(5)]
		public decimal Percent { get; set; }

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
