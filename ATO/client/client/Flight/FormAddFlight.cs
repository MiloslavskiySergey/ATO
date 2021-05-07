using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Flight
{
	public partial class FormAddFlight : Form
	{
		public FormAddFlight()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormAddFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddFlight, "Добавить авиалайнер");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void FormAddFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddFlight formAddFlight = new FormAddFlight();
			formAddFlight.Close();
		}
	}
}
