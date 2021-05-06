using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormRegistration : Form
	{
		public FormRegistration()
		{
			InitializeComponent();
		}

		private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnCreateUser_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAvtorization formAvtorization = new FormAvtorization();
			formAvtorization.Show();
		}
	}
}
