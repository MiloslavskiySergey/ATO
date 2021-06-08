using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void formMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnOrderTicket_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormOrderTicket formOrderTicket = new FormOrderTicket();
			formOrderTicket.Show();
		}

		private void btnAdministration_Click(object sender, EventArgs e)
		{
			Hide();
			FormAdministration formAdministration = new FormAdministration();
			formAdministration.ShowDialog();
			Show();
		}

		private async void FormMain_Load(object sender, EventArgs e)
		{

			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var data = (await client.GetFlights.ExecuteAsync().ConfigureAwait(true))?.Data?.Flights;
			foreach (var flight in data?.Nodes ?? Array.Empty<IGetFlights_Flights_Nodes>())
			{
				gridFlightClient.Rows.Add(new object[] { flight.Id, flight.DateStart, flight.TimeStart, flight.IsActive, flight.Route.Start, flight.Route.Target,
				flight.Route.Time, flight.Air.Seats});
			}
		}
	}
}
