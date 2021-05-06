
namespace client
{
	partial class FormOrderTicket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderTicket));
			this.label1 = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nmrCount = new System.Windows.Forms.NumericUpDown();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbTypeTicket = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbTerget = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbStart = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSearchFlight = new System.Windows.Forms.Button();
			this.btnBuyTicket = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Пользователь:";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(105, 9);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(0, 15);
			this.lblUserName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Фамилия:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Имя:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Отчество:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(116, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 23);
			this.textBox1.TabIndex = 9;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(116, 55);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(172, 23);
			this.textBox2.TabIndex = 10;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(116, 84);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(172, 23);
			this.textBox3.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nmrCount);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cmbTypeTicket);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.cmbTerget);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cmbStart);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(340, 184);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск подходящего рейса:";
			// 
			// nmrCount
			// 
			this.nmrCount.Location = new System.Drawing.Point(141, 142);
			this.nmrCount.Name = "nmrCount";
			this.nmrCount.Size = new System.Drawing.Size(172, 23);
			this.nmrCount.TabIndex = 21;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(141, 84);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(172, 23);
			this.dateTimePicker1.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 90);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 15);
			this.label13.TabIndex = 22;
			this.label13.Text = "Дата:";
			// 
			// cmbTypeTicket
			// 
			this.cmbTypeTicket.FormattingEnabled = true;
			this.cmbTypeTicket.Location = new System.Drawing.Point(141, 113);
			this.cmbTypeTicket.Name = "cmbTypeTicket";
			this.cmbTypeTicket.Size = new System.Drawing.Size(172, 23);
			this.cmbTypeTicket.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 15);
			this.label12.TabIndex = 22;
			this.label12.Text = "Количество мест:";
			// 
			// cmbTerget
			// 
			this.cmbTerget.FormattingEnabled = true;
			this.cmbTerget.Location = new System.Drawing.Point(141, 55);
			this.cmbTerget.Name = "cmbTerget";
			this.cmbTerget.Size = new System.Drawing.Size(172, 23);
			this.cmbTerget.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 15);
			this.label9.TabIndex = 17;
			this.label9.Text = "Место отправления:";
			// 
			// cmbStart
			// 
			this.cmbStart.FormattingEnabled = true;
			this.cmbStart.Location = new System.Drawing.Point(141, 26);
			this.cmbStart.Name = "cmbStart";
			this.cmbStart.Size = new System.Drawing.Size(172, 23);
			this.cmbStart.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 58);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "Место назначения:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 116);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 15);
			this.label11.TabIndex = 19;
			this.label11.Text = "Тип билета:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 274);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(340, 115);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Результат:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(141, 79);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(172, 23);
			this.txtPrice.TabIndex = 22;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(141, 50);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(172, 23);
			this.dateTimePicker2.TabIndex = 22;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(141, 21);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(172, 23);
			this.textBox5.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 15);
			this.label8.TabIndex = 20;
			this.label8.Text = "Дата отправления:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 15);
			this.label7.TabIndex = 20;
			this.label7.Text = "Цена:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 15);
			this.label5.TabIndex = 18;
			this.label5.Text = "Номер рейса:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(358, 37);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 159);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Пользовательские данные:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(116, 113);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(172, 23);
			this.textBox4.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Номер телефона:";
			// 
			// btnSearchFlight
			// 
			this.btnSearchFlight.Location = new System.Drawing.Point(12, 227);
			this.btnSearchFlight.Name = "btnSearchFlight";
			this.btnSearchFlight.Size = new System.Drawing.Size(340, 41);
			this.btnSearchFlight.TabIndex = 19;
			this.btnSearchFlight.Text = "Поиск рейса";
			this.btnSearchFlight.UseVisualStyleBackColor = true;
			// 
			// btnBuyTicket
			// 
			this.btnBuyTicket.Location = new System.Drawing.Point(12, 394);
			this.btnBuyTicket.Name = "btnBuyTicket";
			this.btnBuyTicket.Size = new System.Drawing.Size(164, 39);
			this.btnBuyTicket.TabIndex = 20;
			this.btnBuyTicket.Text = "Купить билеты";
			this.btnBuyTicket.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(182, 395);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(170, 38);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormOrderTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 449);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBuyTicket);
			this.Controls.Add(this.btnSearchFlight);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrderTicket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Покупка билета";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrderTicket_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbStart;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbTerget;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbTypeTicket;
		private System.Windows.Forms.NumericUpDown nmrCount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSearchFlight;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnBuyTicket;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.TextBox textBox5;
	}
}