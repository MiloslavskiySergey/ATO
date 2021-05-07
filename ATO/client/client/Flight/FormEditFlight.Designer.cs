
namespace client.Flight
{
	partial class FormEditFlight
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditFlight));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSaveFlight = new System.Windows.Forms.Button();
			this.cmbSotrudnik = new System.Windows.Forms.ComboBox();
			this.dateCreate = new System.Windows.Forms.DateTimePicker();
			this.txtSeats = new System.Windows.Forms.TextBox();
			this.txtLifeTime = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtBortNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(17, 216);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(139, 19);
			this.checkBox1.TabIndex = 33;
			this.checkBox1.Text = "Готовность к вылету";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(206, 245);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 32;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSaveFlight
			// 
			this.btnSaveFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFlight.Image")));
			this.btnSaveFlight.Location = new System.Drawing.Point(107, 245);
			this.btnSaveFlight.Name = "btnSaveFlight";
			this.btnSaveFlight.Size = new System.Drawing.Size(50, 50);
			this.btnSaveFlight.TabIndex = 31;
			this.btnSaveFlight.UseVisualStyleBackColor = true;
			// 
			// cmbSotrudnik
			// 
			this.cmbSotrudnik.FormattingEnabled = true;
			this.cmbSotrudnik.Location = new System.Drawing.Point(193, 186);
			this.cmbSotrudnik.Name = "cmbSotrudnik";
			this.cmbSotrudnik.Size = new System.Drawing.Size(180, 23);
			this.cmbSotrudnik.TabIndex = 30;
			// 
			// dateCreate
			// 
			this.dateCreate.Location = new System.Drawing.Point(193, 157);
			this.dateCreate.Name = "dateCreate";
			this.dateCreate.Size = new System.Drawing.Size(180, 23);
			this.dateCreate.TabIndex = 29;
			// 
			// txtSeats
			// 
			this.txtSeats.Location = new System.Drawing.Point(193, 128);
			this.txtSeats.Name = "txtSeats";
			this.txtSeats.Size = new System.Drawing.Size(180, 23);
			this.txtSeats.TabIndex = 28;
			// 
			// txtLifeTime
			// 
			this.txtLifeTime.Location = new System.Drawing.Point(193, 99);
			this.txtLifeTime.Name = "txtLifeTime";
			this.txtLifeTime.Size = new System.Drawing.Size(180, 23);
			this.txtLifeTime.TabIndex = 27;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(193, 70);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(180, 23);
			this.txtModel.TabIndex = 26;
			// 
			// txtBortNumber
			// 
			this.txtBortNumber.Location = new System.Drawing.Point(193, 41);
			this.txtBortNumber.Name = "txtBortNumber";
			this.txtBortNumber.Size = new System.Drawing.Size(180, 23);
			this.txtBortNumber.TabIndex = 25;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 189);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 15);
			this.label7.TabIndex = 24;
			this.label7.Text = "Командир авиалайнера:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 15);
			this.label6.TabIndex = 23;
			this.label6.Text = "Дата ввода в эксплуатацию:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 15);
			this.label5.TabIndex = 22;
			this.label5.Text = "Количество посадочных мест:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 15);
			this.label4.TabIndex = 21;
			this.label4.Text = "Срок эксплуатации:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 15);
			this.label3.TabIndex = 20;
			this.label3.Text = "Модель самолета:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 15);
			this.label2.TabIndex = 19;
			this.label2.Text = "Бортовой номер:";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(110, 16);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(0, 15);
			this.lblUser.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "Пользователь:";
			// 
			// FormEditFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 310);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveFlight);
			this.Controls.Add(this.cmbSotrudnik);
			this.Controls.Add(this.dateCreate);
			this.Controls.Add(this.txtSeats);
			this.Controls.Add(this.txtLifeTime);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.txtBortNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormEditFlight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактировать авиалайнер";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditFlight_FormClosed);
			this.Load += new System.EventHandler(this.FormEditFlight_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSaveFlight;
		private System.Windows.Forms.ComboBox cmbSotrudnik;
		private System.Windows.Forms.DateTimePicker dateCreate;
		private System.Windows.Forms.TextBox txtSeats;
		private System.Windows.Forms.TextBox txtLifeTime;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtBortNumber;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label1;
	}
}