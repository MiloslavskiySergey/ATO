using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormEditRoute : Form
	{
		public FormEditRoute()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveRoute_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormEditRoute_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormEditRoute formEditRoute = new FormEditRoute();
			formEditRoute.Close();
		}
	}
}
