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
			this.Close();
		}

		private void FormOrderTicket_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormOrderTicket formOrderTicket = new FormOrderTicket();
			formOrderTicket.Close();
			//Application.Exit();
		}

		private async void btnBuyTicket_Click(object sender, EventArgs e)
		{
			var driverId = await AddOrder(txtMesto.Text,
				Convert.ToInt32(txtCount.Text),
				Convert.ToInt32(txtNumRoute.Text),
				dateTimePicker1.Value,
				txtStart.Text,
				txtTarget.Text,
				cmbTypeTicket.Text/*,
				Convert.ToDecimal(txtPrice.Text)*/);

		}

		private async Task<bool> AddOrder(string mesto,	int counts,	int airId, DateTime dateStart,
			//DateTime timeStart, 
			string start,
			string target,
			string name
			/*Decimal price*/)
		{
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var res = await client.AddOrder.ExecuteAsync(mesto, counts, airId, dateStart, start, target, name /*, price*/).ConfigureAwait(true);
			return res.Errors.Count == 0;
		}

	}
}
