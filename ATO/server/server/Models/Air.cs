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

		[Required, StringLength(10)]
		public string BortNumber { get; set; } = default!;

		[Required, StringLength(10)]
		public string Model { get; set; } = default!;

		[Required]
		public DateTime Date_create { get; set; } = DateTime.Today;

		[Required, StringLength(10)]
		public int LifeTime { get; set; }

		[Required]
		public int Seats { get; set; }

		[Required, StringLength(5)]
		public bool IsActive { get; set; } = false;

		[Required]
		public int SotrudnikId { get; set; }
		public Sotrudnik Sotrudnik { get; set; } = default!;

		public ICollection<Flight> Flights { get; set; } = new List<Flight>();
	}
}
