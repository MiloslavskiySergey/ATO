using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
	public partial class FormAvtorization : Form
	{
		public FormAvtorization()
		{
			InitializeComponent();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnAvtorization_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormRegistration formRegistration = new FormRegistration();
			formRegistration.Show();
		}
	}
}
