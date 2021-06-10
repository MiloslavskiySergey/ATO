using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
	public partial class FormAvtorization : Form
	{
		private readonly SynchronizationContext? syncContext;

		public FormAvtorization()
		{
			InitializeComponent();
			syncContext = SynchronizationContext.Current;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private async void btnAvtorization_Click(object sender, EventArgs e)
		{
            if (txtPasword.Text is null || txtLogin.Text is null || txtPasword.Text.Length == 0 || txtLogin.Text.Length == 0)
                return;
            btnAvtorization.Enabled = false;
            var res = await Auth(txtLogin.Text, txtPasword.Text).ConfigureAwait(true);
            if (res is not null)
            {
                MessageBox.Show(res);
                BeginInvoke((Action)(() => btnAvtorization.Enabled = true));
                return;
            }

            BeginInvoke((Action)(() => ShowMenu()));

            /*this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();*/
        }

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormRegistration formRegistration = new FormRegistration();
			formRegistration.Show();
		}

        private static async Task<string?> Auth(string email, string password)
        {
            var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
            var res = await client.SignIn.ExecuteAsync(email, password).ConfigureAwait(true);
            if (res.Errors.Count > 0)
            {
                return res.Errors[0].Message;
            }
            Program.AccessToken = res?.Data?.SignIn.Token?.AccessToken ?? "";
            Program.RefreshToken = res?.Data?.SignIn.Token?.RefreshToken ?? "";
            return null;
        }

        private void ShowMenu()
        {
            timer1.Start();
            Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            Show();
            btnAvtorization.Enabled = true;
            timer1.Stop();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            var message = await RefreshToken().ConfigureAwait(true);
            if (message is not null)
            {
                BeginInvoke((Action)(() =>
                {
                    Array.ForEach(MdiChildren, x => x.Close());
                    MessageBox.Show(message);
                }));
            }

        }

        private static async Task<string?> RefreshToken()
        {
            if (Program.RefreshToken is null)
            {
                return "not auth";
            }
            var client = Program.ServiceProvider.GetRequiredService<IGqlClient>();
            var res = await client.RefreshToken.ExecuteAsync(Program.RefreshToken).ConfigureAwait(false);
            if (res.Errors.Count > 1)
            {
                return res.Errors[0].Message;
            }
            Program.RefreshToken = res.Data?.RefreshToken?.Token?.RefreshToken ?? "";
            Program.AccessToken = res.Data?.RefreshToken?.Token?.AccessToken ?? "";
            return null;
        }
    }
}
