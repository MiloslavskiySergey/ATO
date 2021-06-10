using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
	public partial class FormOrderTicket : Form
	{
		public FormOrderTicket()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormOrderTicket_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormOrderTicket formOrderTicket = new FormOrderTicket();
			formOrderTicket.Close();
			//Application.Exit();
		}

		private async void btnBuyTicket_Click(object sender, EventArgs e)
		{
			var driverId = await AddOrder(
				txtMesto.Text,
				Convert.ToInt32(txtCount.Text),
				Convert.ToInt32(txtFlightId.Text),
				Convert.ToInt32(txtClientId.Text),
				Convert.ToInt32(txtCardId.Text)
				//Convert.ToInt32(txtNumRoute.Text),
				//dateTimePicker1.Value,
				//cmbStart.Text,
				//cmbTarget.Text,
				//cmbTypeTicket.Text,
				//Convert.ToDecimal(txtPrice.Text)
				);

			MessageBox.Show("Операция произошла");

			Close();

		}

		private async Task<bool> AddOrder(
			string mesto,
			int counts,
			int flightId,
			int clientId,
			int cardId
			//int airId, 
			//DateTime dateStart,
			//DateTime timeStart, 
			//string start,
			//string target,
			//string name,
			//Decimal price
			)
		{
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var res = await client.AddOrder.ExecuteAsync(
				mesto, 
				counts, 
				flightId, 
				clientId, 
				cardId).ConfigureAwait(true);
			return res.Errors.Count == 0;
		}

	}
}
