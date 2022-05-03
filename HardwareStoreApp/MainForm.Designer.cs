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
			this.menu = new System.Windows.Forms.MenuStrip();
			this.authorizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сводныйПоМагазинамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorizeMenuItem,
            this.reportMenuItem,
            this.adminMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(800, 28);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// authorizeMenuItem
			// 
			this.authorizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem});
			this.authorizeMenuItem.Name = "authorizeMenuItem";
			this.authorizeMenuItem.Size = new System.Drawing.Size(115, 24);
			this.authorizeMenuItem.Text = "Авторизация";
			// 
			// loginMenuItem
			// 
			this.loginMenuItem.Name = "loginMenuItem";
			this.loginMenuItem.Size = new System.Drawing.Size(224, 26);
			this.loginMenuItem.Text = "Вход";
			this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
			// 
			// reportMenuItem
			// 
			this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сводныйПоМагазинамToolStripMenuItem});
			this.reportMenuItem.Name = "reportMenuItem";
			this.reportMenuItem.Size = new System.Drawing.Size(73, 24);
			this.reportMenuItem.Text = "Отчеты";
			// 
			// сводныйПоМагазинамToolStripMenuItem
			// 
			this.сводныйПоМагазинамToolStripMenuItem.Name = "сводныйПоМагазинамToolStripMenuItem";
			this.сводныйПоМагазинамToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.сводныйПоМагазинамToolStripMenuItem.Text = "Продажи";
			// 
			// adminMenuItem
			// 
			this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuItem});
			this.adminMenuItem.Name = "adminMenuItem";
			this.adminMenuItem.Size = new System.Drawing.Size(170, 24);
			this.adminMenuItem.Text = "Администрирование";
			// 
			// manageUsersMenuItem
			// 
			this.manageUsersMenuItem.Name = "manageUsersMenuItem";
			this.manageUsersMenuItem.Size = new System.Drawing.Size(297, 26);
			this.manageUsersMenuItem.Text = "Управление пользователями";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 24);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(14, 24);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.Text = "Магазин бытовой техники";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сводныйПоМагазинамToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageUsersMenuItem;
		private System.Windows.Forms.Button btnLoginForm;
		private System.Windows.Forms.ToolStripMenuItem authorizeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
	}
}
