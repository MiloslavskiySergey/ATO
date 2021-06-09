using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Sotrudnik
{
	public partial class FormAddSotrudnik : Form
	{
		public FormAddSotrudnik()
		{
			InitializeComponent();
		}

		private void FormAddSotrudnik_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddSotrudnik, "Добавить сотрудника");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAddSotrudnik_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddSotrudnik formAddSotrudnik = new FormAddSotrudnik();
			formAddSotrudnik.Close();
		}

		private async void btnAddSotrudnik_Click(object sender, EventArgs e)
		{
			var sotrudnik = await AddSotrudnik(
				textBox1.Text,
				textBox2.Text,
				textBox3.Text,
				textBox4.Text,
				textBox5.Text,
				Convert.ToInt32(textBox6.Text)
				);

			MessageBox.Show("Операция произошла");

			Close();
		}

		private async Task<bool> AddSotrudnik(
			string lastName,
			string name,
			string surName,
			string addres,
			string phone,
			int stage)
		{
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var res = await client.AddSotrudnik.ExecuteAsync(
				lastName,
				name,
				surName,
				addres,
				phone,
				stage
				).ConfigureAwait(true);
			return res.Errors.Count == 0;
		}
	}
}
