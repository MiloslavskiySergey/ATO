using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace client
{
	public partial class FormSellTicket : Form
	{
		public FormSellTicket()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormSellTicket_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSellTicket formSellTicket = new FormSellTicket();
			formSellTicket.Close();
		}

		private async void FormSellTicket_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSellTicket, "Добавить");
			toolTip.SetToolTip(this.btnEditSellTicket, "Изменить");
			toolTip.SetToolTip(this.btnDeleteSellTicket, "Удалить");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск маршрута");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");

			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var data = (await client.GetOrders.ExecuteAsync().ConfigureAwait(true))?.Data?.Orders;
			foreach (var order in data?.Nodes ?? Array.Empty<IGetOrders_Orders_Nodes>())
			{
				dataGridView1.Rows.Add(new object[] { order.Id,
				order.Flight.Route.Start,
				order.Flight.Route.Target,
				order.Flight.Route.Time,
				order.Mesto,
				order.Client.LastName,
				order.Client.Name,
				order.Client.SurName,
				order.Client.Phone,
				order.Card.Name,
				order.Flight.Route.Price
				});
			}
		}

		private void btnAddSellTicket_Click(object sender, EventArgs e)
		{

		}
	}
}
