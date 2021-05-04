using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Flight
	{
		public int Id { get; set; }
		[Required]

		//нужно как то отделить
		public DateTime Date_start { get; set; } = default!;
		[Required]

		public DateTime Time_start { get; set; } = default!;
		[Required]

		public bool IsActive { get; set; } = default!;
		
		public int Route_id { get; set; }
		[Required]
		public Route Route { get; set; } = default!;

		public int Air_id { get; set; }
		[Required]
		public Air Air { get; set; } = default!;

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
