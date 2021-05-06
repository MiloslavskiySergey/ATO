
namespace client
{
	partial class FormEditRoute
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditRoute));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStart = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.btnSaveRoute = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Место отправления:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "Базовая стоимость, руб:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "Место назначения:";
			// 
			// txtStart
			// 
			this.txtStart.Location = new System.Drawing.Point(171, 23);
			this.txtStart.Name = "txtStart";
			this.txtStart.Size = new System.Drawing.Size(192, 23);
			this.txtStart.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "Время вылета, мин:";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(171, 110);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(192, 23);
			this.txtTime.TabIndex = 19;
			// 
			// txtPlace
			// 
			this.txtPlace.Location = new System.Drawing.Point(171, 81);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(192, 23);
			this.txtPlace.TabIndex = 18;
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(198, 139);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtTarget
			// 
			this.txtTarget.Location = new System.Drawing.Point(171, 52);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(192, 23);
			this.txtTarget.TabIndex = 17;
			// 
			// btnSaveRoute
			// 
			this.btnSaveRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRoute.Image")));
			this.btnSaveRoute.Location = new System.Drawing.Point(104, 139);
			this.btnSaveRoute.Name = "btnSaveRoute";
			this.btnSaveRoute.Size = new System.Drawing.Size(50, 50);
			this.btnSaveRoute.TabIndex = 14;
			this.btnSaveRoute.UseVisualStyleBackColor = true;
			this.btnSaveRoute.Click += new System.EventHandler(this.btnSaveRoute_Click);
			// 
			// FormEditRoute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 210);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtPlace);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtTarget);
			this.Controls.Add(this.btnSaveRoute);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormEditRoute";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактирование маршрута";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditRoute_FormClosed);
			this.Load += new System.EventHandler(this.FormEditRoute_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.Button btnSaveRoute;
		private System.Windows.Forms.ToolTip toolTip;
	}
}