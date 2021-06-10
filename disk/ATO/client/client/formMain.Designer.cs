
namespace client
{
	partial class FormMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.label1 = new System.Windows.Forms.Label();
			this.btnOrderTicket = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.gridFlightClient = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RouteStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RouteTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FreePlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAdministration = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.btnClearSearch = new System.Windows.Forms.Button();
			this.btnHistoryOrder = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFlightClient)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Доступные рейсы:";
			// 
			// btnOrderTicket
			// 
			this.btnOrderTicket.Location = new System.Drawing.Point(346, 125);
			this.btnOrderTicket.Name = "btnOrderTicket";
			this.btnOrderTicket.Size = new System.Drawing.Size(122, 23);
			this.btnOrderTicket.TabIndex = 2;
			this.btnOrderTicket.Text = "Заказать билет";
			this.btnOrderTicket.UseVisualStyleBackColor = true;
			this.btnOrderTicket.Click += new System.EventHandler(this.btnOrderTicket_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 109);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Место назначения:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Место отправления:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(131, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(175, 23);
			this.textBox2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(131, 14);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 23);
			this.textBox1.TabIndex = 0;
			// 
			// gridFlightClient
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gridFlightClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridFlightClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridFlightClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFlightClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.DateStart,
            this.TimeStart,
            this.Open,
            this.RouteStart,
            this.RouteTarget,
            this.TimeFlight,
            this.FreePlaces});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridFlightClient.DefaultCellStyle = dataGridViewCellStyle11;
			this.gridFlightClient.Location = new System.Drawing.Point(12, 168);
			this.gridFlightClient.Name = "gridFlightClient";
			this.gridFlightClient.RowTemplate.Height = 25;
			this.gridFlightClient.Size = new System.Drawing.Size(958, 392);
			this.gridFlightClient.TabIndex = 6;
			// 
			// number
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.number.DefaultCellStyle = dataGridViewCellStyle3;
			this.number.HeaderText = "№";
			this.number.Name = "number";
			this.number.ReadOnly = true;
			this.number.Width = 40;
			// 
			// DateStart
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DateStart.DefaultCellStyle = dataGridViewCellStyle4;
			this.DateStart.HeaderText = "Дата отправления";
			this.DateStart.Name = "DateStart";
			this.DateStart.ReadOnly = true;
			this.DateStart.Width = 135;
			// 
			// TimeStart
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TimeStart.DefaultCellStyle = dataGridViewCellStyle5;
			this.TimeStart.HeaderText = "Время отправления";
			this.TimeStart.Name = "TimeStart";
			this.TimeStart.ReadOnly = true;
			this.TimeStart.Width = 140;
			// 
			// Open
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Open.DefaultCellStyle = dataGridViewCellStyle6;
			this.Open.HeaderText = "Открыт";
			this.Open.Name = "Open";
			this.Open.ReadOnly = true;
			this.Open.Width = 50;
			// 
			// RouteStart
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.RouteStart.DefaultCellStyle = dataGridViewCellStyle7;
			this.RouteStart.HeaderText = "Отправление";
			this.RouteStart.Name = "RouteStart";
			this.RouteStart.ReadOnly = true;
			// 
			// RouteTarget
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.RouteTarget.DefaultCellStyle = dataGridViewCellStyle8;
			this.RouteTarget.HeaderText = "Прибытие";
			this.RouteTarget.Name = "RouteTarget";
			this.RouteTarget.ReadOnly = true;
			// 
			// TimeFlight
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TimeFlight.DefaultCellStyle = dataGridViewCellStyle9;
			this.TimeFlight.HeaderText = "Время полета, мин";
			this.TimeFlight.Name = "TimeFlight";
			this.TimeFlight.ReadOnly = true;
			this.TimeFlight.Width = 135;
			// 
			// FreePlaces
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FreePlaces.DefaultCellStyle = dataGridViewCellStyle10;
			this.FreePlaces.HeaderText = "Свободные места";
			this.FreePlaces.Name = "FreePlaces";
			this.FreePlaces.ReadOnly = true;
			this.FreePlaces.Width = 140;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(346, 38);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(122, 23);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnAdministration
			// 
			this.btnAdministration.Location = new System.Drawing.Point(827, 38);
			this.btnAdministration.Name = "btnAdministration";
			this.btnAdministration.Size = new System.Drawing.Size(143, 23);
			this.btnAdministration.TabIndex = 8;
			this.btnAdministration.Text = "Администрирование";
			this.btnAdministration.UseVisualStyleBackColor = true;
			this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(18, 9);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(87, 15);
			this.lblUser.TabIndex = 9;
			this.lblUser.Text = "Пользователь:";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(111, 9);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(0, 15);
			this.lblUserName.TabIndex = 10;
			// 
			// btnClearSearch
			// 
			this.btnClearSearch.Location = new System.Drawing.Point(346, 67);
			this.btnClearSearch.Name = "btnClearSearch";
			this.btnClearSearch.Size = new System.Drawing.Size(122, 23);
			this.btnClearSearch.TabIndex = 11;
			this.btnClearSearch.Text = "Сброс";
			this.btnClearSearch.UseVisualStyleBackColor = true;
			// 
			// btnHistoryOrder
			// 
			this.btnHistoryOrder.Location = new System.Drawing.Point(346, 96);
			this.btnHistoryOrder.Name = "btnHistoryOrder";
			this.btnHistoryOrder.Size = new System.Drawing.Size(122, 23);
			this.btnHistoryOrder.TabIndex = 12;
			this.btnHistoryOrder.Text = "История заказов";
			this.btnHistoryOrder.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 572);
			this.Controls.Add(this.btnHistoryOrder);
			this.Controls.Add(this.btnClearSearch);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.btnAdministration);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.gridFlightClient);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOrderTicket);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главная форма";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFlightClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOrderTicket;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView gridFlightClient;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnAdministration;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn Open;
		private System.Windows.Forms.DataGridViewTextBoxColumn RouteStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn RouteTarget;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeFlight;
		private System.Windows.Forms.DataGridViewTextBoxColumn FreePlaces;
		private System.Windows.Forms.Button btnClearSearch;
		private System.Windows.Forms.Button btnHistoryOrder;
	}
}