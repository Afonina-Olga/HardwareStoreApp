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
			this.components = new System.ComponentModel.Container();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.authorizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addProductsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fillDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.productGrid = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbRegion = new System.Windows.Forms.ComboBox();
			this.cbStore = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cbFullSearch = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.cbExact = new System.Windows.Forms.CheckBox();
			this.cbMinPrice = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
			this.bsCategory = new System.Windows.Forms.BindingSource(this.components);
			this.bsRegions = new System.Windows.Forms.BindingSource(this.components);
			this.bsStores = new System.Windows.Forms.BindingSource(this.components);
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsRegions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStores)).BeginInit();
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
            this.salesReportMenuItem});
			this.reportMenuItem.Name = "reportMenuItem";
			this.reportMenuItem.Size = new System.Drawing.Size(73, 24);
			this.reportMenuItem.Text = "Отчеты";
			// 
			// salesReportMenuItem
			// 
			this.salesReportMenuItem.Name = "salesReportMenuItem";
			this.salesReportMenuItem.Size = new System.Drawing.Size(157, 26);
			this.salesReportMenuItem.Text = "Продажи";
			this.salesReportMenuItem.Click += new System.EventHandler(this.SalesMenuItem_Click);
			// 
			// adminMenuItem
			// 
			this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuItem,
            this.addProductsMenuItem,
            this.salesMenuItem,
            this.fillDatabaseMenuItem});
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
			// addProductsMenuItem
			// 
			this.addProductsMenuItem.Name = "addProductsMenuItem";
			this.addProductsMenuItem.Size = new System.Drawing.Size(297, 26);
			this.addProductsMenuItem.Text = "Приемка товаров";
			this.addProductsMenuItem.Click += new System.EventHandler(this.AddProductsMenuItem_Click);
			// 
			// salesMenuItem
			// 
			this.salesMenuItem.Name = "salesMenuItem";
			this.salesMenuItem.Size = new System.Drawing.Size(297, 26);
			this.salesMenuItem.Text = "Продажа товаров";
			this.salesMenuItem.Click += new System.EventHandler(this.SalesMenuItem_Click);
			// 
			// fillDatabaseMenuItem
			// 
			this.fillDatabaseMenuItem.Name = "fillDatabaseMenuItem";
			this.fillDatabaseMenuItem.Size = new System.Drawing.Size(297, 26);
			this.fillDatabaseMenuItem.Text = "Справочники";
			this.fillDatabaseMenuItem.Click += new System.EventHandler(this.FillDatabaseMenuItem_Click);
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
			this.productGrid.Location = new System.Drawing.Point(15, 238);
			this.productGrid.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.productGrid.Name = "productGrid";
			this.productGrid.RowHeadersWidth = 51;
			this.productGrid.RowTemplate.Height = 29;
			this.productGrid.Size = new System.Drawing.Size(770, 134);
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
			// cbRegion
			// 
			this.cbRegion.FormattingEnabled = true;
			this.cbRegion.Location = new System.Drawing.Point(13, 35);
			this.cbRegion.Name = "cbRegion";
			this.cbRegion.Size = new System.Drawing.Size(288, 28);
			this.cbRegion.TabIndex = 5;
			this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.CbRegion_SelectedIndexChanged);
			// 
			// cbStore
			// 
			this.cbStore.FormattingEnabled = true;
			this.cbStore.Location = new System.Drawing.Point(321, 35);
			this.cbStore.Name = "cbStore";
			this.cbStore.Size = new System.Drawing.Size(288, 28);
			this.cbStore.TabIndex = 7;
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
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(13, 89);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(288, 27);
			this.txtName.TabIndex = 9;
			// 
			// cbFullSearch
			// 
			this.cbFullSearch.AutoSize = true;
			this.cbFullSearch.Location = new System.Drawing.Point(13, 194);
			this.cbFullSearch.Name = "cbFullSearch";
			this.cbFullSearch.Size = new System.Drawing.Size(303, 24);
			this.cbFullSearch.TabIndex = 13;
			this.cbFullSearch.Text = "Продолжить поиск в других магазинах";
			this.cbFullSearch.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.cbCategory);
			this.panel1.Controls.Add(this.btnApply);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.cbExact);
			this.panel1.Controls.Add(this.cbMinPrice);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbFullSearch);
			this.panel1.Controls.Add(this.cbRegion);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbStore);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 232);
			this.panel1.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(321, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 23;
			this.label5.Text = "Категория";
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(321, 89);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(288, 28);
			this.cbCategory.TabIndex = 22;
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(505, 189);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(105, 29);
			this.btnApply.TabIndex = 21;
			this.btnApply.Text = "Применить";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(394, 189);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(105, 29);
			this.btnClear.TabIndex = 20;
			this.btnClear.Text = "Очистить";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// cbExact
			// 
			this.cbExact.AutoSize = true;
			this.cbExact.Location = new System.Drawing.Point(12, 122);
			this.cbExact.Name = "cbExact";
			this.cbExact.Size = new System.Drawing.Size(169, 24);
			this.cbExact.TabIndex = 19;
			this.cbExact.Text = "Точное совпадение";
			this.cbExact.UseVisualStyleBackColor = true;
			// 
			// cbMinPrice
			// 
			this.cbMinPrice.AutoSize = true;
			this.cbMinPrice.Location = new System.Drawing.Point(13, 164);
			this.cbMinPrice.Name = "cbMinPrice";
			this.cbMinPrice.Size = new System.Drawing.Size(156, 24);
			this.cbMinPrice.TabIndex = 18;
			this.cbMinPrice.Text = "Сначала дешевые";
			this.cbMinPrice.UseVisualStyleBackColor = true;
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 238F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
			this.tableLayoutPanel1.TabIndex = 15;
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
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsRegions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesReportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageUsersMenuItem;
		private System.Windows.Forms.ToolStripMenuItem authorizeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
		private System.Windows.Forms.DataGridView productGrid;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbRegion;
		private System.Windows.Forms.ComboBox cbStore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.CheckBox cbFullSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripMenuItem addProductsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fillDatabaseMenuItem;
		private System.Windows.Forms.BindingSource bsProduct;
		private System.Windows.Forms.CheckBox cbMinPrice;
		private System.Windows.Forms.ToolStripMenuItem salesMenuItem;
		private System.Windows.Forms.CheckBox cbExact;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.BindingSource bsCategory;
		private System.Windows.Forms.BindingSource bsRegions;
		private System.Windows.Forms.BindingSource bsStores;
	}
}
