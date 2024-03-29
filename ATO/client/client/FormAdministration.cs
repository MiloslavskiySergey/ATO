﻿using System;
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
			Hide();
			FormMain formMain = new FormMain();
			formMain.ShowDialog();
		}

		private void FormAdministration_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnRoute_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormRoute formRoute = new FormRoute();
			formRoute.ShowDialog();
		}

		private void btnFlight_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormFlight formFlight = new FormFlight();
			formFlight.ShowDialog();
		}

		private void btnSotrudnik_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormSotrudnik formSotrudnik = new FormSotrudnik();
			formSotrudnik.ShowDialog();
		}

		private void btnClient_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormClient formClient = new FormClient();
			formClient.ShowDialog();
		}

		private void btnControlFlight_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormControlFlight formControlFlight = new FormControlFlight();
			formControlFlight.ShowDialog();
		}

		private void btnSellTicket_Click(object sender, EventArgs e)
		{
			//this.Hide();
			FormSellTicket formSellTicket = new FormSellTicket();
			formSellTicket.ShowDialog();
		}

		private void FormAdministration_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnRoute, "Информация о маршрутах");
			toolTip.SetToolTip(this.btnFlight, "Информация о авиалайнерах");
			toolTip.SetToolTip(this.btnSotrudnik, "Информация о сотрудниках");
			toolTip.SetToolTip(this.btnClient, "Информация о клиентах");
			toolTip.SetToolTip(this.btnControlFlight, "Информация о рейсах");
			toolTip.SetToolTip(this.btnSellTicket, "Информация о заявках");
			toolTip.SetToolTip(this.btnCancel, "Вернуться на главное окно");
		}
	}
}
