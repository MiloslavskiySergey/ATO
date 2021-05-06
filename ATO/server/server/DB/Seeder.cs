using Casbin.Adapter.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using server.Models;
using System.Collections.Generic;
using System;


namespace server.DB
{
	public static partial class Seeder
	{
		public static void SeedAll(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Air>().HasData(
				new Air
				{
					Id = 1,
					BortNumber = "RU2415115",
					Model = "Boing-747",
					//Date_create = 1 / 6 / 2005,
					LifeTime = 20,
					IsActive = true,
					Seats = 200,
					SotrudnikId = 1
				},
				new Air
				{
					Id = 2,
					BortNumber = "RU2354251",
					Model = "Boing-747",
					//Date_create = 01.06.2005,
					LifeTime = 25,
					IsActive = true,
					Seats = 250,
					SotrudnikId = 2
				},
				new Air
				{
					Id = 3,
					BortNumber = "RU252521",
					Model = "Ty-134",
					//Date_create = 01.06.2010,
					LifeTime = 25,
					IsActive = false,
					Seats = 199,
					SotrudnikId = 3
				}
				);
			modelBuilder.Entity<Card>().HasData(
				new Card
				{
					Id = 1,
					Name = "Эконом класс",
					Percent = 0
				},
				new Card
				{
					Id = 2,
					Name = "VIP",
					Percent = 30
				}
				);
			modelBuilder.Entity<Client>().HasData(
				new Client
				{
					Id = 1,
					LastName = "Макушев",
					Name = "Сергей",
					SurName = "Иванович",
					PassportSeia = 2423,
					PassportNumber = 242342,
					Addres = "Smolensk",
					Phone = "812345678"
				},
				new Client
				{
					Id = 2,
					LastName = "Татарин",
					Name = "Иван",
					SurName = "Степанович",
					PassportSeia = 4646,
					PassportNumber = 535353,
					Addres = "Smolensk",
					Phone = "8856564545"
				}
				);
			modelBuilder.Entity<Flight>().HasData(
				new Flight
				{
					Id = 1,
					//Date_start = 20.12.2019,
					//Time_start = 16:00,
					IsActive = false,
					AirId = 1,
					RouteId = 1
				},
				new Flight
				{
					Id = 2,
					//Date_start = 20.12.2019,
					//Time_start = 13:00,
					IsActive = false,
					AirId = 2,
					RouteId = 2
				},
				new Flight
				{
					Id = 3,
					//Date_start = 19.12.2019,
					//Time_start = 12:00,
					IsActive = false,
					AirId = 3,
					RouteId = 3
				},
				new Flight
				{
					Id = 4,
					//Date_start = 27.12.2019,
					//Time_start = 12:00,
					IsActive = true,
					AirId = 2,
					RouteId = 3
				}
				);
			modelBuilder.Entity<Order>().HasData(
				new Order
				{
					Id = 5,
					Mesto = "1",
					Counts = 1,
					FlightId = 1,
					ClientId = 1,
					CardId = 1
				},
				new Order
				{
					Id = 6,
					Mesto = "2",
					Counts = 1,
					FlightId = 1,
					ClientId = 1,
					CardId = 2
				},
				new Order
				{
					Id = 7,
					Mesto = "3",
					Counts = 1,
					FlightId = 4,
					ClientId = 1,
					CardId = 1
				}
				);
			modelBuilder.Entity<Route>().HasData(
				new Route
				{
					Id = 1,
					Start = "Москва",
					Target = "Санкт-Петербург",
					Price = 5000,
					Time = 60
				},
				new Route
				{
					Id = 2,
					Start = "Москва",
					Target = "Сочи",
					Price = 9000,
					Time = 120
				},
				new Route
				{
					Id = 3,
					Start = "Москва",
					Target = "Ростов-на-Дону",
					Price = 7000,
					Time = 80
				}
				);
			modelBuilder.Entity<Sotrudnik>().HasData(
				new Sotrudnik
				{
					Id = 1,
					Last_name = "Маслюков",
					Name = "Валерий",
					Sur_name = "Степанович",
					Addres = "Смоленск",
					Phone = "89556454",
					Stage = 9
				},
				new Sotrudnik
				{
					Id = 2,
					Last_name = "Новиков",
					Name = "Станислав",
					Sur_name = "Иванович",
					Addres = "Moskva",
					Phone = "89568756454",
					Stage = 10
				},
				new Sotrudnik
				{
					Id = 3,
					Last_name = "Скрипкин",
					Name = "Семен",
					Sur_name = "Эдуардович",
					Addres = "Roslavl",
					Phone = "8955665454",
					Stage = 8
				}
				);
			modelBuilder.Entity<CasbinRule<int>>().HasData(
				new CasbinRule<int>() { Id = 1, V0 = "p", V1 = "role_admin", V2 = "*", V3 = "*" });
		}
	}
}
