using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Sotrudnik
{
	public partial class FormAddSotrudnik : Form
	{
		public FormAddSotrudnik()
		{
			InitializeComponent();
		}

		private void FormAddSotrudnik_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSotrudnik, "Добавить сотрудника");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormAddSotrudnik_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddSotrudnik formAddSotrudnik = new FormAddSotrudnik();
			formAddSotrudnik.Close();
		}
	}
}
