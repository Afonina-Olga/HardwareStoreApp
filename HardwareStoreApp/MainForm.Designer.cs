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
			this.productGrid = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbDistrict = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
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
			this.loginMenuItem.Size = new System.Drawing.Size(125, 26);
			this.loginMenuItem.Text = "Вход";
			this.loginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
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
			this.сводныйПоМагазинамToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
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
			this.manageUsersMenuItem.Click += new System.EventHandler(this.ManageUsersMenuItem_Click);
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
			// productGrid
			// 
			this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productGrid.Location = new System.Drawing.Point(15, 160);
			this.productGrid.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.productGrid.Name = "productGrid";
			this.productGrid.RowHeadersWidth = 51;
			this.productGrid.RowTemplate.Height = 29;
			this.productGrid.Size = new System.Drawing.Size(770, 212);
			this.productGrid.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(691, 382);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0, 10, 15, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Район";
			// 
			// cmbDistrict
			// 
			this.cmbDistrict.FormattingEnabled = true;
			this.cmbDistrict.Location = new System.Drawing.Point(13, 35);
			this.cmbDistrict.Name = "cmbDistrict";
			this.cmbDistrict.Size = new System.Drawing.Size(288, 28);
			this.cmbDistrict.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(321, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(288, 28);
			this.comboBox1.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(321, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Магазин";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Название товара";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 89);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(288, 27);
			this.textBox1.TabIndex = 9;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(13, 122);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(121, 24);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Искать везде";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.cmbDistrict);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 154);
			this.panel1.TabIndex = 14;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.productGrid, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(321, 90);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(168, 24);
			this.radioButton1.TabIndex = 14;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Точное совпадение";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(495, 92);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(123, 24);
			this.radioButton4.TabIndex = 15;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Начинается с";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.Text = "Магазин бытовой техники";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сводныйПоМагазинамToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageUsersMenuItem;
		private System.Windows.Forms.ToolStripMenuItem authorizeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
		private System.Windows.Forms.DataGridView productGrid;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbDistrict;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}
