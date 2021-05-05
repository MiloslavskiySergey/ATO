﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
	public class Client
	{
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string Last_name { get; set; } = default!;

		[Required, StringLength(30)]
		public string Name { get; set; } = default!;

		[Required, StringLength(30)]
		public string Sur_name { get; set; } = default!;

		[Required, StringLength(4)]
		public int Passport_seia { get; set; }

		[Required, StringLength(6)]
		public int Passport_number { get; set; }

		[Required, StringLength(30)]
		public string Addres { get; set; } = default!;

		[Required, StringLength(30)]
		public string Phone { get; set; } = default!;

		public ICollection<Order> Orders { get; set; } = new List<Order>();
	}
}
