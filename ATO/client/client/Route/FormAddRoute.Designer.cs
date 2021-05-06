
namespace client
{
	partial class FormAddRoute
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRoute));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddRoute = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtStart = new System.Windows.Forms.TextBox();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место отправления:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Место назначения:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Базовая стоимость, руб:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Время вылета, мин:";
			// 
			// btnAddRoute
			// 
			this.btnAddRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoute.Image")));
			this.btnAddRoute.Location = new System.Drawing.Point(116, 144);
			this.btnAddRoute.Name = "btnAddRoute";
			this.btnAddRoute.Size = new System.Drawing.Size(50, 50);
			this.btnAddRoute.TabIndex = 4;
			this.btnAddRoute.UseVisualStyleBackColor = true;
			this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(186, 144);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtStart
			// 
			this.txtStart.Location = new System.Drawing.Point(169, 28);
			this.txtStart.Name = "txtStart";
			this.txtStart.Size = new System.Drawing.Size(192, 23);
			this.txtStart.TabIndex = 6;
			// 
			// txtTarget
			// 
			this.txtTarget.Location = new System.Drawing.Point(169, 57);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(192, 23);
			this.txtTarget.TabIndex = 7;
			// 
			// txtPlace
			// 
			this.txtPlace.Location = new System.Drawing.Point(169, 86);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(192, 23);
			this.txtPlace.TabIndex = 8;
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(169, 115);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(192, 23);
			this.txtTime.TabIndex = 9;
			// 
			// FormAddRoute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 211);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtPlace);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtTarget);
			this.Controls.Add(this.btnAddRoute);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAddRoute";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление маршрута";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddRoute_FormClosed);
			this.Load += new System.EventHandler(this.FormAddRoute_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddRoute;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtStart;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.ToolTip toolTip;
	}
}