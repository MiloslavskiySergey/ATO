using client.Flight;
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
			this.Close();
		}

		private void FormFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormFlight formFlight = new FormFlight();
			formFlight.Close();
		}

		private void FormFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddFlight, "Добавить авиалайнер");
			toolTip.SetToolTip(this.btnEditFlight, "Изменить информацию о авиалайнере");
			toolTip.SetToolTip(this.btnDeleteFlight, "Удалить авиалайнер");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}

		private void btnAddFlight_Click(object sender, EventArgs e)
		{
			FormAddFlight formAddFlight = new FormAddFlight();
			formAddFlight.Show();
		}

		private void btnEditFlight_Click(object sender, EventArgs e)
		{
			FormEditFlight formEditFlight = new FormEditFlight();
			formEditFlight.Show();
		}
	}
}
