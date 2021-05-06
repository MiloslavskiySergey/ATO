using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

		private void FormSotrudnik_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSotrudnik, "Добавить сотрудника");
			toolTip.SetToolTip(this.btnEditSotrudnik, "Изменить информацию о сотруднике");
			toolTip.SetToolTip(this.btnDeleteSotrudnik, "Удалить сотрудника");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}
	}
}
