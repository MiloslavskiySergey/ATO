using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Flight
	{
		public int id { get; set; }
		[Required]

		//нужно как то отделить
		public DateTime date_start { get; set; } = default!;
		[Required]

		public DateTime time_start { get; set; } = default!;
		[Required]

		public bool isActive { get; set; } = default!;
		
		public int route_id { get; set; }
		[Required]
		public Route route { get; set; } = default!;

		public int air_id { get; set; }
		[Required]
		public Air air { get; set; } = default!;

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
