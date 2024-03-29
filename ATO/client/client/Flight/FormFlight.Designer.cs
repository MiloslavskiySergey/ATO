﻿
namespace client
{
	partial class FormFlight
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlight));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDeleteFlight = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddFlight = new System.Windows.Forms.Button();
			this.btnEditFlight = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearSearch = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sur_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date_create = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lifeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDeleteFlight);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAddFlight);
			this.panel1.Controls.Add(this.btnEditFlight);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 64);
			this.panel1.TabIndex = 0;
			// 
			// btnDeleteFlight
			// 
			this.btnDeleteFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFlight.Image")));
			this.btnDeleteFlight.Location = new System.Drawing.Point(123, 7);
			this.btnDeleteFlight.Name = "btnDeleteFlight";
			this.btnDeleteFlight.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteFlight.TabIndex = 3;
			this.btnDeleteFlight.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(179, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddFlight
			// 
			this.btnAddFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFlight.Image")));
			this.btnAddFlight.Location = new System.Drawing.Point(11, 7);
			this.btnAddFlight.Name = "btnAddFlight";
			this.btnAddFlight.Size = new System.Drawing.Size(50, 50);
			this.btnAddFlight.TabIndex = 1;
			this.btnAddFlight.UseVisualStyleBackColor = true;
			this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
			// 
			// btnEditFlight
			// 
			this.btnEditFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFlight.Image")));
			this.btnEditFlight.Location = new System.Drawing.Point(67, 7);
			this.btnEditFlight.Name = "btnEditFlight";
			this.btnEditFlight.Size = new System.Drawing.Size(50, 50);
			this.btnEditFlight.TabIndex = 2;
			this.btnEditFlight.UseVisualStyleBackColor = true;
			this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClearSearch);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 82);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 289);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// btnClearSearch
			// 
			this.btnClearSearch.Location = new System.Drawing.Point(101, 198);
			this.btnClearSearch.Name = "btnClearSearch";
			this.btnClearSearch.Size = new System.Drawing.Size(50, 50);
			this.btnClearSearch.TabIndex = 8;
			this.btnClearSearch.Text = "Сброс";
			this.btnClearSearch.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(34, 198);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(50, 50);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 169);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 23);
			this.comboBox1.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 125);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(188, 23);
			this.textBox3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Командир:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 81);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(188, 23);
			this.textBox2.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 23);
			this.textBox1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Модель:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "№ самолета:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Бортовой номер:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.bortNumber,
            this.model,
            this.last_name,
            this.name,
            this.sur_name,
            this.date_create,
            this.lifeTime,
            this.isActive,
            this.seats});
			this.dataGridView1.Location = new System.Drawing.Point(218, 82);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(879, 289);
			this.dataGridView1.TabIndex = 3;
			// 
			// number
			// 
			this.number.HeaderText = "№";
			this.number.Name = "number";
			// 
			// bortNumber
			// 
			this.bortNumber.HeaderText = "Бортовой №";
			this.bortNumber.Name = "bortNumber";
			// 
			// model
			// 
			this.model.HeaderText = "Модель";
			this.model.Name = "model";
			// 
			// last_name
			// 
			this.last_name.HeaderText = "Фамилия";
			this.last_name.Name = "last_name";
			// 
			// name
			// 
			this.name.HeaderText = "Имя";
			this.name.Name = "name";
			// 
			// sur_name
			// 
			this.sur_name.HeaderText = "Отчество";
			this.sur_name.Name = "sur_name";
			// 
			// date_create
			// 
			this.date_create.HeaderText = "Ввод в эксплуатацию";
			this.date_create.Name = "date_create";
			// 
			// lifeTime
			// 
			this.lifeTime.HeaderText = "Срок эксплуатации";
			this.lifeTime.Name = "lifeTime";
			// 
			// isActive
			// 
			this.isActive.HeaderText = "Готовность";
			this.isActive.Name = "isActive";
			// 
			// seats
			// 
			this.seats.HeaderText = "Места";
			this.seats.Name = "seats";
			// 
			// FormFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1097, 383);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormFlight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авиалайнеры";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFlight_FormClosed);
			this.Load += new System.EventHandler(this.FormFlight_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddFlight;
		private System.Windows.Forms.Button btnEditFlight;
		private System.Windows.Forms.Button btnDeleteFlight;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnClearSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		private System.Windows.Forms.DataGridViewTextBoxColumn bortNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn model;
		private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn sur_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn date_create;
		private System.Windows.Forms.DataGridViewTextBoxColumn lifeTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
		private System.Windows.Forms.DataGridViewTextBoxColumn seats;
	}
}