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
	public partial class FormAddRoute : Form
	{
		public FormAddRoute()
		{
			InitializeComponent();
		}

		private async void btnAddRoute_Click(object sender, EventArgs e)
		{
			

			var route = await AddRoute(
				txtStart.Text,
				txtTarget.Text,
				Convert.ToInt32(txtTime.Text),
				Convert.ToDecimal(txtPrice.Text)
				);

			MessageBox.Show("Операция произошла" /*+ (await AddRoute(
				txtStart.Text,
				txtTarget.Text,
				Convert.ToInt32(txtTime.Text),
				Convert.ToDecimal(txtPrice.Text)).ConfigureAwait(true) ? " успешно" : "не успешно")*/);

			Close();

		}

		private async Task<bool> AddRoute(
			string start,
			string target,
			int time,
			Decimal price)
		{
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var res = await client.AddRoute.ExecuteAsync(start, target, time, price).ConfigureAwait(true);
			return res.Errors.Count == 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAddRoute_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddRoute formAddRoute = new FormAddRoute();
			formAddRoute.Close();
		}

		private void FormAddRoute_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddRoute , "Добавить маршрут");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}
	}
}
