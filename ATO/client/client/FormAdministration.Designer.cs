
namespace client
{
	partial class FormAdministration
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministration));
			this.btnRoute = new System.Windows.Forms.Button();
			this.btnFlight = new System.Windows.Forms.Button();
			this.btnSotrudnik = new System.Windows.Forms.Button();
			this.btnClient = new System.Windows.Forms.Button();
			this.btnControlFlight = new System.Windows.Forms.Button();
			this.btnSellTicket = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnRoute
			// 
			this.btnRoute.Location = new System.Drawing.Point(48, 39);
			this.btnRoute.Name = "btnRoute";
			this.btnRoute.Size = new System.Drawing.Size(165, 70);
			this.btnRoute.TabIndex = 0;
			this.btnRoute.Text = "Маршруты";
			this.btnRoute.UseVisualStyleBackColor = true;
			this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
			// 
			// btnFlight
			// 
			this.btnFlight.Location = new System.Drawing.Point(236, 39);
			this.btnFlight.Name = "btnFlight";
			this.btnFlight.Size = new System.Drawing.Size(165, 70);
			this.btnFlight.TabIndex = 1;
			this.btnFlight.Text = "Авиалайнеры";
			this.btnFlight.UseVisualStyleBackColor = true;
			this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
			// 
			// btnSotrudnik
			// 
			this.btnSotrudnik.Location = new System.Drawing.Point(48, 115);
			this.btnSotrudnik.Name = "btnSotrudnik";
			this.btnSotrudnik.Size = new System.Drawing.Size(165, 70);
			this.btnSotrudnik.TabIndex = 2;
			this.btnSotrudnik.Text = "Сотрудники";
			this.btnSotrudnik.UseVisualStyleBackColor = true;
			this.btnSotrudnik.Click += new System.EventHandler(this.btnSotrudnik_Click);
			// 
			// btnClient
			// 
			this.btnClient.Location = new System.Drawing.Point(236, 115);
			this.btnClient.Name = "btnClient";
			this.btnClient.Size = new System.Drawing.Size(165, 70);
			this.btnClient.TabIndex = 3;
			this.btnClient.Text = "Клиенты";
			this.btnClient.UseVisualStyleBackColor = true;
			this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
			// 
			// btnControlFlight
			// 
			this.btnControlFlight.Location = new System.Drawing.Point(48, 191);
			this.btnControlFlight.Name = "btnControlFlight";
			this.btnControlFlight.Size = new System.Drawing.Size(165, 70);
			this.btnControlFlight.TabIndex = 4;
			this.btnControlFlight.Text = "Управление рейсами";
			this.btnControlFlight.UseVisualStyleBackColor = true;
			this.btnControlFlight.Click += new System.EventHandler(this.btnControlFlight_Click);
			// 
			// btnSellTicket
			// 
			this.btnSellTicket.Location = new System.Drawing.Point(236, 191);
			this.btnSellTicket.Name = "btnSellTicket";
			this.btnSellTicket.Size = new System.Drawing.Size(165, 70);
			this.btnSellTicket.TabIndex = 5;
			this.btnSellTicket.Text = "Продажа билетов";
			this.btnSellTicket.UseVisualStyleBackColor = true;
			this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(201, 267);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormAdministration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 323);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSellTicket);
			this.Controls.Add(this.btnControlFlight);
			this.Controls.Add(this.btnClient);
			this.Controls.Add(this.btnSotrudnik);
			this.Controls.Add(this.btnFlight);
			this.Controls.Add(this.btnRoute);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAdministration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Администрирование";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdministration_FormClosed);
			this.Load += new System.EventHandler(this.FormAdministration_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRoute;
		private System.Windows.Forms.Button btnFlight;
		private System.Windows.Forms.Button btnSotrudnik;
		private System.Windows.Forms.Button btnClient;
		private System.Windows.Forms.Button btnControlFlight;
		private System.Windows.Forms.Button btnSellTicket;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolTip toolTip;
	}
}