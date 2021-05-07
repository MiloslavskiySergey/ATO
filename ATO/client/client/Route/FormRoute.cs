﻿using System;
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
			this.Close();
			/*
			this.Hide();
			FormAdministration formAdministration = new FormAdministration();
			formAdministration.Show();
			*/
		}

		private void FormRoute_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormRoute formRoute = new FormRoute();
			formRoute.Close();
			//Application.Exit();
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

		private void FormRoute_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddRoute, "Добавить маршрут");
			toolTip.SetToolTip(this.btnEditRoute, "Изменить маршрут");
			toolTip.SetToolTip(this.btnDeleteRoute, "Удалить маршрут");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск маршрута");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}
	}
}