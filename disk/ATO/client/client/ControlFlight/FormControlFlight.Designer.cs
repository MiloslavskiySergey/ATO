
namespace client
{
	partial class FormControlFlight
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlFlight));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDeleteControlFlight = new System.Windows.Forms.Button();
			this.btnAddControlFlight = new System.Windows.Forms.Button();
			this.btnEditControlFlight = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cmb = new System.Windows.Forms.ComboBox();
			this.btnClearSearch = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnDeleteControlFlight);
			this.panel1.Controls.Add(this.btnAddControlFlight);
			this.panel1.Controls.Add(this.btnEditControlFlight);
			this.panel1.Location = new System.Drawing.Point(12, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 64);
			this.panel1.TabIndex = 9;
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(177, 9);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnDeleteControlFlight
			// 
			this.btnDeleteControlFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteControlFlight.Image")));
			this.btnDeleteControlFlight.Location = new System.Drawing.Point(121, 9);
			this.btnDeleteControlFlight.Name = "btnDeleteControlFlight";
			this.btnDeleteControlFlight.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteControlFlight.TabIndex = 2;
			this.btnDeleteControlFlight.UseVisualStyleBackColor = true;
			// 
			// btnAddControlFlight
			// 
			this.btnAddControlFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnAddControlFlight.Image")));
			this.btnAddControlFlight.Location = new System.Drawing.Point(11, 9);
			this.btnAddControlFlight.Name = "btnAddControlFlight";
			this.btnAddControlFlight.Size = new System.Drawing.Size(50, 50);
			this.btnAddControlFlight.TabIndex = 1;
			this.btnAddControlFlight.UseVisualStyleBackColor = true;
			this.btnAddControlFlight.Click += new System.EventHandler(this.btnAddControlFlight_Click);
			// 
			// btnEditControlFlight
			// 
			this.btnEditControlFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnEditControlFlight.Image")));
			this.btnEditControlFlight.Location = new System.Drawing.Point(66, 9);
			this.btnEditControlFlight.Name = "btnEditControlFlight";
			this.btnEditControlFlight.Size = new System.Drawing.Size(50, 50);
			this.btnEditControlFlight.TabIndex = 1;
			this.btnEditControlFlight.UseVisualStyleBackColor = true;
			this.btnEditControlFlight.Click += new System.EventHandler(this.btnEditControlFlight_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.cmb);
			this.groupBox1.Controls.Add(this.btnClearSearch);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 279);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(11, 125);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 23);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(11, 81);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(183, 23);
			this.comboBox1.TabIndex = 9;
			// 
			// cmb
			// 
			this.cmb.FormattingEnabled = true;
			this.cmb.Location = new System.Drawing.Point(11, 37);
			this.cmb.Name = "cmb";
			this.cmb.Size = new System.Drawing.Size(183, 23);
			this.cmb.TabIndex = 8;
			// 
			// btnClearSearch
			// 
			this.btnClearSearch.Location = new System.Drawing.Point(101, 154);
			this.btnClearSearch.Name = "btnClearSearch";
			this.btnClearSearch.Size = new System.Drawing.Size(50, 50);
			this.btnClearSearch.TabIndex = 7;
			this.btnClearSearch.Text = "Сброс";
			this.btnClearSearch.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(35, 154);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(50, 50);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Дата:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Самолет:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Маршрут";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(227, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(561, 279);
			this.dataGridView1.TabIndex = 11;
			// 
			// FormControlFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 383);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlFlight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление рейсами";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormControlFlight_FormClosed);
			this.Load += new System.EventHandler(this.FormControlFlight_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDeleteControlFlight;
		private System.Windows.Forms.Button btnAddControlFlight;
		private System.Windows.Forms.Button btnEditControlFlight;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox cmb;
		private System.Windows.Forms.Button btnClearSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolTip toolTip;
	}
}