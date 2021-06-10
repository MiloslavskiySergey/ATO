using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Sotrudnik
	{
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string Last_name { get; set; } = default!;

		[Required, StringLength(30)]
		public string Name { get; set; } = default!;

		[Required, StringLength(30)]
		public string Sur_name { get; set; } = default!;

		[Required, StringLength(30)]
		public string Addres { get; set; } = default!;

		[Required, StringLength(30)]
		public string Phone { get; set; } = default!;

		[Required, StringLength(3)]
		public int Stage { get; set; }

		public ICollection<Air> Airs { get; set; } = new List<Air>();
	}
}
