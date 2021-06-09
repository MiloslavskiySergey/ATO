using client.Flight;
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
	public partial class FormFlight : Form
	{
		public FormFlight()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormFlight formFlight = new FormFlight();
			formFlight.Close();
		}

		private async void FormFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddFlight, "Добавить авиалайнер");
			toolTip.SetToolTip(this.btnEditFlight, "Изменить информацию о авиалайнере");
			toolTip.SetToolTip(this.btnDeleteFlight, "Удалить авиалайнер");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
			
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var data = (await client.GetAirs.ExecuteAsync().ConfigureAwait(true))?.Data?.Airs;
			foreach (var air in data?.Nodes ?? Array.Empty<IGetAirs_Airs_Nodes>())
			{
				dataGridView1.Rows.Add(new object[] { air.Id,
					air.BortNumber, 
					air.Model, 
					air.Sotrudnik.Last_name,
					air.Sotrudnik.Name,
					air.Sotrudnik.Sur_name,
					air.Date_create,
					air.LifeTime,
					air.IsActive,
					air.Seats
				});
			}
		}

		private void btnAddFlight_Click(object sender, EventArgs e)
		{
			FormAddFlight formAddFlight = new FormAddFlight();
			formAddFlight.ShowDialog();
		}

		private void btnEditFlight_Click(object sender, EventArgs e)
		{
			FormEditFlight formEditFlight = new FormEditFlight();
			formEditFlight.ShowDialog();
		}
	}
}
