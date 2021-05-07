using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Sotrudnik
{
	public partial class FormEditSotrudnik : Form
	{
		public FormEditSotrudnik()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormEditSotrudnik_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnSaveSotrudnik, "Сохранить изменения");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void FormEditSotrudnik_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormEditSotrudnik formEditSotrudnik = new FormEditSotrudnik();
			formEditSotrudnik.Close();
		}
	}
}
