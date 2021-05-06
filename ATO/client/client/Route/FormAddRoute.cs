using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormAddRoute : Form
	{
		public FormAddRoute()
		{
			InitializeComponent();
		}

		private void btnAddRoute_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormAddRoute_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddRoute formAddRoute = new FormAddRoute();
			formAddRoute.Close();
		}

		private void FormAddRoute_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddRoute , "Добавить маршрут");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}
	}
}
