
namespace client
{
	partial class FormSellTicket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellTicket));
			this.btnAddSellTicket = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDeleteSellTicket = new System.Windows.Forms.Button();
			this.btnEditSellTicket = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cmb = new System.Windows.Forms.ComboBox();
			this.btnClearSearch = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typebilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddSellTicket
			// 
			this.btnAddSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSellTicket.Image")));
			this.btnAddSellTicket.Location = new System.Drawing.Point(11, 9);
			this.btnAddSellTicket.Name = "btnAddSellTicket";
			this.btnAddSellTicket.Size = new System.Drawing.Size(50, 50);
			this.btnAddSellTicket.TabIndex = 1;
			this.btnAddSellTicket.UseVisualStyleBackColor = true;
			this.btnAddSellTicket.Click += new System.EventHandler(this.btnAddSellTicket_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnDeleteSellTicket);
			this.panel1.Controls.Add(this.btnAddSellTicket);
			this.panel1.Controls.Add(this.btnEditSellTicket);
			this.panel1.Location = new System.Drawing.Point(12, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 64);
			this.panel1.TabIndex = 12;
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
			// btnDeleteSellTicket
			// 
			this.btnDeleteSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSellTicket.Image")));
			this.btnDeleteSellTicket.Location = new System.Drawing.Point(121, 9);
			this.btnDeleteSellTicket.Name = "btnDeleteSellTicket";
			this.btnDeleteSellTicket.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteSellTicket.TabIndex = 2;
			this.btnDeleteSellTicket.UseVisualStyleBackColor = true;
			// 
			// btnEditSellTicket
			// 
			this.btnEditSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSellTicket.Image")));
			this.btnEditSellTicket.Location = new System.Drawing.Point(66, 9);
			this.btnEditSellTicket.Name = "btnEditSellTicket";
			this.btnEditSellTicket.Size = new System.Drawing.Size(50, 50);
			this.btnEditSellTicket.TabIndex = 1;
			this.btnEditSellTicket.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.cmb);
			this.groupBox1.Controls.Add(this.btnClearSearch);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 279);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
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
			this.btnClearSearch.Location = new System.Drawing.Point(100, 110);
			this.btnClearSearch.Name = "btnClearSearch";
			this.btnClearSearch.Size = new System.Drawing.Size(50, 50);
			this.btnClearSearch.TabIndex = 7;
			this.btnClearSearch.Text = "Сброс";
			this.btnClearSearch.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(34, 110);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(50, 50);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Клиент:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Рейс:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.start,
            this.target,
            this.time,
            this.mesto,
            this.lastName,
            this.name,
            this.surName,
            this.phone,
            this.typebilet,
            this.price});
			this.dataGridView1.Location = new System.Drawing.Point(227, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(561, 279);
			this.dataGridView1.TabIndex = 14;
			// 
			// number
			// 
			this.number.HeaderText = "№";
			this.number.Name = "number";
			// 
			// start
			// 
			this.start.HeaderText = "Место отправления";
			this.start.Name = "start";
			// 
			// target
			// 
			this.target.HeaderText = "Место прибытия";
			this.target.Name = "target";
			// 
			// time
			// 
			this.time.HeaderText = "Время";
			this.time.Name = "time";
			// 
			// mesto
			// 
			this.mesto.HeaderText = "Место";
			this.mesto.Name = "mesto";
			// 
			// lastName
			// 
			this.lastName.HeaderText = "Фамилия";
			this.lastName.Name = "lastName";
			// 
			// name
			// 
			this.name.HeaderText = "Имя";
			this.name.Name = "name";
			// 
			// surName
			// 
			this.surName.HeaderText = "Отчество";
			this.surName.Name = "surName";
			// 
			// phone
			// 
			this.phone.HeaderText = "Телефон";
			this.phone.Name = "phone";
			// 
			// typebilet
			// 
			this.typebilet.HeaderText = "Тип билета";
			this.typebilet.Name = "typebilet";
			// 
			// price
			// 
			this.price.HeaderText = "Базовая цена";
			this.price.Name = "price";
			// 
			// FormSellTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 383);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormSellTicket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Продажа билетов";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSellTicket_FormClosed);
			this.Load += new System.EventHandler(this.FormSellTicket_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddSellTicket;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDeleteSellTicket;
		private System.Windows.Forms.Button btnEditSellTicket;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox cmb;
		private System.Windows.Forms.Button btnClearSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		private System.Windows.Forms.DataGridViewTextBoxColumn start;
		private System.Windows.Forms.DataGridViewTextBoxColumn target;
		private System.Windows.Forms.DataGridViewTextBoxColumn time;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn surName;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn typebilet;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
	}
}