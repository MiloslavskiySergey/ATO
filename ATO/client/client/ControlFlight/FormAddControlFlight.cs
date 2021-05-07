using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormAddControlFlight : Form
	{
		public FormAddControlFlight()
		{
			InitializeComponent();
		}

		private void FormAddControlFlight_Load(object sender, EventArgs e)
		{

		}

		private void btnAddControlFlight_Click(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddControlFlight, "Добавить рейс");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void FormAddControlFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddControlFlight formAddControlFlight = new FormAddControlFlight();
			formAddControlFlight.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
