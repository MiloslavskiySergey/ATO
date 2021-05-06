using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void formMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnOrderTicket_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormOrderTicket formOrderTicket = new FormOrderTicket();
			formOrderTicket.Show();
		}

		private void btnAdministration_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAdministration formAdministration = new FormAdministration();
			formAdministration.Show();
		}
	}
}
