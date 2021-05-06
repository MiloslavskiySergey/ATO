using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormAdministration : Form
	{
		public FormAdministration()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();
		}

		private void FormAdministration_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnRoute_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormRoute formRoute = new FormRoute();
			formRoute.Show();
		}

		private void btnFlight_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormFlight formFlight = new FormFlight();
			formFlight.Show();
		}

		private void btnSotrudnik_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormSotrudnik formSotrudnik = new FormSotrudnik();
			formSotrudnik.Show();
		}

		private void btnClient_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormClient formClient = new FormClient();
			formClient.Show();
		}

		private void btnControlFlight_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormControlFlight formControlFlight = new FormControlFlight();
			formControlFlight.Show();
		}

		private void btnSellTicket_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormSellTicket formSellTicket = new FormSellTicket();
			formSellTicket.Show();
		}
	}
}
