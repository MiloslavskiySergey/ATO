using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.ControlFlight
{
	public partial class FormEditControlFlight : Form
	{
		public FormEditControlFlight()
		{
			InitializeComponent();
		}

		private void FormEditControlFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnSaveControlFlight, "Сохранить изменения");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormEditControlFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormEditControlFlight formEditControlFlight = new FormEditControlFlight();
			formEditControlFlight.Close();
		}
	}
}
