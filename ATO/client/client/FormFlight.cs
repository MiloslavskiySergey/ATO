using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormFlight : Form
	{
		public FormFlight()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
			FormAdministration formAdministration = new FormAdministration();
			formAdministration.Show();
		}
	}
}
