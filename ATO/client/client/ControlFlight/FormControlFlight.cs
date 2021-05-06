using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormControlFlight : Form
	{
		public FormControlFlight()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormControlFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormControlFlight formControlFlight = new FormControlFlight();
			formControlFlight.Close();
		}

		private void FormControlFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddControlFlight, "Добавить рейс");
			toolTip.SetToolTip(this.btnEditControlFlight, "Изменить информацию о рейсе");
			toolTip.SetToolTip(this.btnDeleteControlFlight, "Удалить рейс");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}
	}
}
