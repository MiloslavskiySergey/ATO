using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormOrderTicket : Form
	{
		public FormOrderTicket()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();
		}

		private void FormOrderTicket_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
