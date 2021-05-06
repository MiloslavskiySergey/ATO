
namespace client
{
	partial class FormClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.btnAddClient = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearSearch = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			this.panel1.Controls.Add(this.btnDeleteClient);
			this.panel1.Controls.Add(this.btnAddClient);
			this.panel1.Controls.Add(this.btnEditClient);
			this.panel1.Location = new System.Drawing.Point(12, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 64);
			this.panel1.TabIndex = 6;
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
			// btnDeleteClient
			// 
			this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
			this.btnDeleteClient.Location = new System.Drawing.Point(121, 9);
			this.btnDeleteClient.Name = "btnDeleteClient";
			this.btnDeleteClient.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteClient.TabIndex = 2;
			this.btnDeleteClient.UseVisualStyleBackColor = true;
			// 
			// btnAddClient
			// 
			this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
			this.btnAddClient.Location = new System.Drawing.Point(11, 9);
			this.btnAddClient.Name = "btnAddClient";
			this.btnAddClient.Size = new System.Drawing.Size(50, 50);
			this.btnAddClient.TabIndex = 1;
			this.btnAddClient.UseVisualStyleBackColor = true;
			// 
			// btnEditClient
			// 
			this.btnEditClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEditClient.Image")));
			this.btnEditClient.Location = new System.Drawing.Point(66, 9);
			this.btnEditClient.Name = "btnEditClient";
			this.btnEditClient.Size = new System.Drawing.Size(50, 50);
			this.btnEditClient.TabIndex = 1;
			this.btnEditClient.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClearSearch);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 279);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// btnClearSearch
			// 
			this.btnClearSearch.Location = new System.Drawing.Point(100, 154);
			this.btnClearSearch.Name = "btnClearSearch";
			this.btnClearSearch.Size = new System.Drawing.Size(50, 50);
			this.btnClearSearch.TabIndex = 7;
			this.btnClearSearch.Text = "Сброс";
			this.btnClearSearch.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(34, 154);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(50, 50);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(11, 125);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(183, 23);
			this.textBox3.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(11, 81);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(183, 23);
			this.textBox2.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(11, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 23);
			this.textBox1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Отчество:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фамилия:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(227, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(561, 279);
			this.dataGridView1.TabIndex = 8;
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 383);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Клиенты";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
			this.Load += new System.EventHandler(this.FormClient_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDeleteClient;
		private System.Windows.Forms.Button btnAddClient;
		private System.Windows.Forms.Button btnEditClient;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClearSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolTip toolTip;
	}
}