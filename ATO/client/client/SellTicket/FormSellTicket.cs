using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
			this.Close();
		}

		private void FormSellTicket_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSellTicket formSellTicket = new FormSellTicket();
			formSellTicket.Close();
		}

		private void FormSellTicket_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSellTicket, "Добавить");
			toolTip.SetToolTip(this.btnEditSellTicket, "Изменить");
			toolTip.SetToolTip(this.btnDeleteSellTicket, "Удалить");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск маршрута");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}
	}
}
