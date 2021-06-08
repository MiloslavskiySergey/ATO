using client.Sotrudnik;
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
	public partial class FormSotrudnik : Form
	{
		public FormSotrudnik()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormSotrudnik_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSotrudnik formSotrudnik = new FormSotrudnik();
			formSotrudnik.Close();
		}

		private async void FormSotrudnik_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSotrudnik, "Добавить сотрудника");
			toolTip.SetToolTip(this.btnEditSotrudnik, "Изменить информацию о сотруднике");
			toolTip.SetToolTip(this.btnDeleteSotrudnik, "Удалить сотрудника");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
			
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var data = (await client.GetSotrudniks.ExecuteAsync().ConfigureAwait(true))?.Data?.Sotrudniks;
			foreach (var sotrudnik in data?.Nodes ?? Array.Empty<IGetSotrudniks_Sotrudniks_Nodes>())
			{
				dataGridView1.Rows.Add(new object[] { sotrudnik.Id,
				sotrudnik.Last_name,
				sotrudnik.Name,
				sotrudnik.Sur_name,
				sotrudnik.Phone,
				sotrudnik.Stage,
				sotrudnik.Addres
				});
			}
		}

		private void btnAddSotrudnik_Click(object sender, EventArgs e)
		{
			FormAddSotrudnik formAddSotrudnik = new FormAddSotrudnik();
			formAddSotrudnik.Show();
		}

		private void btnEditSotrudnik_Click(object sender, EventArgs e)
		{
			FormEditSotrudnik formEditSotrudnik = new FormEditSotrudnik();
			formEditSotrudnik.Show();
		}
	}
}
