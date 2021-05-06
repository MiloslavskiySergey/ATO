using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormRoute : Form
	{
		public FormRoute()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAdministration formAdministration = new FormAdministration();
			formAdministration.Show();
		}

		private void FormRoute_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnAddRoute_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormAddRoute formAddRoute = new FormAddRoute();
			formAddRoute.Show();
		}

		private void btnEditRoute_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormEditRoute formEditRoute = new FormEditRoute();
			formEditRoute.Show();
		}
	}
}
