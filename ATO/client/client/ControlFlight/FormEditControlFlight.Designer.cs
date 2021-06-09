
namespace client.ControlFlight
{
	partial class FormEditControlFlight
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditControlFlight));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSaveControlFlight = new System.Windows.Forms.Button();
			this.txtTimeStart = new System.Windows.Forms.TextBox();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.cmbRoute = new System.Windows.Forms.ComboBox();
			this.cmbFlight = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(185, 159);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 47;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSaveControlFlight
			// 
			this.btnSaveControlFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveControlFlight.Image")));
			this.btnSaveControlFlight.Location = new System.Drawing.Point(108, 159);
			this.btnSaveControlFlight.Name = "btnSaveControlFlight";
			this.btnSaveControlFlight.Size = new System.Drawing.Size(50, 50);
			this.btnSaveControlFlight.TabIndex = 46;
			this.btnSaveControlFlight.UseVisualStyleBackColor = true;
			this.btnSaveControlFlight.Click += new System.EventHandler(this.btnSaveControlFlight_Click);
			// 
			// txtTimeStart
			// 
			this.txtTimeStart.Location = new System.Drawing.Point(98, 130);
			this.txtTimeStart.Name = "txtTimeStart";
			this.txtTimeStart.Size = new System.Drawing.Size(60, 23);
			this.txtTimeStart.TabIndex = 45;
			// 
			// dateStart
			// 
			this.dateStart.Location = new System.Drawing.Point(98, 101);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(151, 23);
			this.dateStart.TabIndex = 44;
			// 
			// cmbRoute
			// 
			this.cmbRoute.FormattingEnabled = true;
			this.cmbRoute.Location = new System.Drawing.Point(98, 72);
			this.cmbRoute.Name = "cmbRoute";
			this.cmbRoute.Size = new System.Drawing.Size(251, 23);
			this.cmbRoute.TabIndex = 43;
			// 
			// cmbFlight
			// 
			this.cmbFlight.FormattingEnabled = true;
			this.cmbFlight.Location = new System.Drawing.Point(98, 43);
			this.cmbFlight.Name = "cmbFlight";
			this.cmbFlight.Size = new System.Drawing.Size(251, 23);
			this.cmbFlight.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 15);
			this.label6.TabIndex = 41;
			this.label6.Text = "Время:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 15);
			this.label5.TabIndex = 40;
			this.label5.Text = "Дата:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 39;
			this.label4.Text = "Маршрут:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 15);
			this.label3.TabIndex = 38;
			this.label3.Text = "Авиалайнер:";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(108, 16);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(0, 15);
			this.lblUser.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 36;
			this.label1.Text = "Пользователь:";
			// 
			// FormEditControlFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 225);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveControlFlight);
			this.Controls.Add(this.txtTimeStart);
			this.Controls.Add(this.dateStart);
			this.Controls.Add(this.cmbRoute);
			this.Controls.Add(this.cmbFlight);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormEditControlFlight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактировать рейс";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditControlFlight_FormClosed);
			this.Load += new System.EventHandler(this.FormEditControlFlight_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSaveControlFlight;
		private System.Windows.Forms.TextBox txtTimeStart;
		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.ComboBox cmbRoute;
		private System.Windows.Forms.ComboBox cmbFlight;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip;
	}
}