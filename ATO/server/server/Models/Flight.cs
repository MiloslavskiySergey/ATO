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
		public DateTime Date_start { get; set; } = DateTime.Today;

		[Required]
		public DateTime Time_start { get; set; } = DateTime.Today;

		[Required]
		public bool IsActive { get; set; } = false;

		[Required]
		public int Route_id { get; set; }
		public Route Route { get; set; } = default!;

		[Required]
		public int Air_id { get; set; }
		public Air Air { get; set; } = default!;

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
