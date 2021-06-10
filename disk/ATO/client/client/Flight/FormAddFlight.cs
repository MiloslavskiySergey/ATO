using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Flight
{
	public partial class FormAddFlight : Form
	{
		public FormAddFlight()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAddFlight_Load(object sender, EventArgs e)
		{
			toolTip.SetToolTip(this.btnAddFlight, "Добавить авиалайнер");
			toolTip.SetToolTip(this.btnCancel, "Отмена");
		}

		private void FormAddFlight_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormAddFlight formAddFlight = new FormAddFlight();
			formAddFlight.Close();
		}

		private async void btnAddFlight_Click(object sender, EventArgs e)
		{
			var air = await AddAir(
				txtBortNumber.Text,
				txtModel.Text,
				Convert.ToInt32(txtLifeTime.Text),
				Convert.ToInt32(txtSeats.Text),
				dateCreate.Value,
				checkBox1.Checked,
				Convert.ToInt32(cmbSotrudnik.Text)
				);

			MessageBox.Show("Операция произошла");

			Close();
		}


		private async Task<bool> AddAir(
            string bortNumber, 
            string models, 
            int lifeTime,
            int seats,
            DateTime dateCreate,
            bool isActive,
            int sotrudnikId)
		{
			var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
			var res = await client.AddAir.ExecuteAsync(
				bortNumber,
				models,
				lifeTime,
				seats,
				dateCreate,
				isActive,
				sotrudnikId
				).ConfigureAwait(true);
			return res.Errors.Count == 0;
		}
	}
}
