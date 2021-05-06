﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
	public partial class FormClient : Form
	{
		public FormClient()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormClient formClient = new FormClient();
			formClient.Close();
		}

		private void FormClient_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddClient, "Добавить клиента");
			toolTip.SetToolTip(this.btnEditClient, "Изменить информацию клиента");
			toolTip.SetToolTip(this.btnDeleteClient, "Удалить клиента");
			toolTip.SetToolTip(this.btnCancel, "Вернуться назад");
			toolTip.SetToolTip(this.btnSearch, "Поиск клиента");
			toolTip.SetToolTip(this.btnClearSearch, "Сброс поиска");
		}
	}
}
