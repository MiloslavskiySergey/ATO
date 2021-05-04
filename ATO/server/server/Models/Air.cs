using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Air
	{
		public int Id { get; set; }
		[Required]

		public string Bort_number { get; set; } = default!;
		[Required, StringLength(10)]

		public string Model { get; set; } = default!;
		[Required, StringLength(10)]

		public DateTime Date_create { get; set; } = default!;
		[Required]

		public int Life_time { get; set; } = default!;
		[Required, StringLength(10)]

		public int Seats { get; set; } = default!;
		[Required]

		public bool IsActive { get; set; } = default!;
		[Required, StringLength(5)]

		public int Sotrudnik_id { get; set; }
		[Required]
		public Sotrudnik Sotrudnik { get; set; } = default!;

		public ICollection<Flight> Flights { get; set; } = new List<Flight>();
	}
}
