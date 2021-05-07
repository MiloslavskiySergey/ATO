using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Flight
{
	public partial class FormEditFlight : Form
	{
		public FormEditFlight()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormEditFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnSaveFlight, "Добавить авиалайнер");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void FormEditFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormEditFlight formEditFlight = new FormEditFlight();
			formEditFlight.Close();
		}
	}
}
