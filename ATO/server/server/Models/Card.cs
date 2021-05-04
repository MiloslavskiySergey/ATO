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
		[Required]

		public string Name { get; set; } = default!;
		[Required, StringLength(30)]

		public int Percent { get; set; } = default!;
		[Required, StringLength(3)]

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
