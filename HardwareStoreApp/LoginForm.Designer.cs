namespace HardwareStoreApp
{
	partial class LoginForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.errorMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(80, 20);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(270, 27);
			this.txtLogin.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(80, 66);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(270, 27);
			this.txtPassword.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(217, 108);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(133, 29);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(80, 108);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(131, 29);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Вход";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// statusBar
			// 
			this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorMessage,
            this.toolStripStatusLabel1});
			this.statusBar.Location = new System.Drawing.Point(0, 147);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(362, 24);
			this.statusBar.TabIndex = 7;
			this.statusBar.Text = "statusStrip1";
			// 
			// errorMessage
			// 
			this.errorMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
			this.errorMessage.Name = "errorMessage";
			this.errorMessage.Size = new System.Drawing.Size(0, 18);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkRed;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 171);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "Авторизация";
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel errorMessage;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}