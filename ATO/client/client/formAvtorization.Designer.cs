
namespace client
{
	partial class FormAvtorization
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvtorization));
			this.btnAvtorization = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPasword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAvtorization
			// 
			this.btnAvtorization.Location = new System.Drawing.Point(182, 151);
			this.btnAvtorization.Name = "btnAvtorization";
			this.btnAvtorization.Size = new System.Drawing.Size(181, 23);
			this.btnAvtorization.TabIndex = 0;
			this.btnAvtorization.Text = "Войти";
			this.btnAvtorization.UseVisualStyleBackColor = true;
			this.btnAvtorization.Click += new System.EventHandler(this.btnAvtorization_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(182, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Пароль";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(182, 57);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(181, 23);
			this.txtLogin.TabIndex = 3;
			// 
			// txtPasword
			// 
			this.txtPasword.Location = new System.Drawing.Point(182, 111);
			this.txtPasword.Name = "txtPasword";
			this.txtPasword.Size = new System.Drawing.Size(181, 23);
			this.txtPasword.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(209, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Создать аккаунт";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// FormAvtorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 247);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPasword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAvtorization);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAvtorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAvtorization;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtPasword;
		private System.Windows.Forms.Label label3;
	}
}

