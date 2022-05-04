namespace HardwareStoreApp
{
	partial class ManageUserAccountsForm
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
			this.userGrid = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cbRole = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// userGrid
			// 
			this.userGrid.AllowUserToAddRows = false;
			this.userGrid.AllowUserToDeleteRows = false;
			this.userGrid.AllowUserToResizeColumns = false;
			this.userGrid.AllowUserToResizeRows = false;
			this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.userGrid.Location = new System.Drawing.Point(13, 169);
			this.userGrid.Name = "userGrid";
			this.userGrid.ReadOnly = true;
			this.userGrid.RowHeadersWidth = 51;
			this.userGrid.RowTemplate.Height = 29;
			this.userGrid.Size = new System.Drawing.Size(446, 208);
			this.userGrid.TabIndex = 0;
			this.userGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellContentClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(366, 386);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(80, 94);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(380, 27);
			this.txtPassword.TabIndex = 2;
			// 
			// cbRole
			// 
			this.cbRole.FormattingEnabled = true;
			this.cbRole.Items.AddRange(new object[] {
            "Администратор",
            "Продавец"});
			this.cbRole.Location = new System.Drawing.Point(81, 14);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(378, 28);
			this.cbRole.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(367, 127);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 29);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(81, 54);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(378, 27);
			this.txtLogin.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Роль";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Пароль";
			// 
			// ManageUserAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 427);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbRole);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.userGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "ManageUserAccounts";
			this.Text = "Управление пользователями";
			this.Load += new System.EventHandler(this.ManageUserAccounts_Load);
			((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView userGrid;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.ComboBox cbRole;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}