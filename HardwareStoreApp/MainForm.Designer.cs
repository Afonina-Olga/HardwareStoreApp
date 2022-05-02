namespace HardwareStoreApp
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сводныйПоМагазинамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogin = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem,
            this.администрированиеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// отчетыToolStripMenuItem
			// 
			this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сводныйПоМагазинамToolStripMenuItem});
			this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// администрированиеToolStripMenuItem
			// 
			this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеПользователямиToolStripMenuItem});
			this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
			this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
			this.администрированиеToolStripMenuItem.Text = "Администрирование";
			// 
			// управлениеПользователямиToolStripMenuItem
			// 
			this.управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
			this.управлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
			this.управлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
			// 
			// сводныйПоМагазинамToolStripMenuItem
			// 
			this.сводныйПоМагазинамToolStripMenuItem.Name = "сводныйПоМагазинамToolStripMenuItem";
			this.сводныйПоМагазинамToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
			this.сводныйПоМагазинамToolStripMenuItem.Text = "Сводный по магазинам";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.Window;
			this.btnLogin.Location = new System.Drawing.Point(615, 41);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(173, 29);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Вход в систему";
			this.btnLogin.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Магазин бытовой техники";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сводныйПоМагазинамToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
		private System.Windows.Forms.Button btnLogin;
	}
}
