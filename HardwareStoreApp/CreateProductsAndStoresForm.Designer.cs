namespace HardwareStoreApp
{
	partial class CreateProductsAndStoresForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddStore = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHouse = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtStoreName = new System.Windows.Forms.TextBox();
			this.txtDistrict = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddStore);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtHouse);
			this.groupBox1.Controls.Add(this.txtStreet);
			this.groupBox1.Controls.Add(this.txtStoreName);
			this.groupBox1.Controls.Add(this.txtDistrict);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(287, 331);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление магазинов";
			// 
			// btnAddStore
			// 
			this.btnAddStore.Location = new System.Drawing.Point(175, 271);
			this.btnAddStore.Name = "btnAddStore";
			this.btnAddStore.Size = new System.Drawing.Size(94, 29);
			this.btnAddStore.TabIndex = 13;
			this.btnAddStore.Text = "Добавить";
			this.btnAddStore.UseVisualStyleBackColor = true;
			this.btnAddStore.Click += new System.EventHandler(this.BtnAddStore_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Дом";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Улица";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Название магазина";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Район";
			// 
			// txtHouse
			// 
			this.txtHouse.Location = new System.Drawing.Point(21, 227);
			this.txtHouse.Name = "txtHouse";
			this.txtHouse.Size = new System.Drawing.Size(248, 27);
			this.txtHouse.TabIndex = 4;
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(21, 167);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(248, 27);
			this.txtStreet.TabIndex = 2;
			// 
			// txtStoreName
			// 
			this.txtStoreName.Location = new System.Drawing.Point(21, 115);
			this.txtStoreName.Name = "txtStoreName";
			this.txtStoreName.Size = new System.Drawing.Size(248, 27);
			this.txtStoreName.TabIndex = 1;
			// 
			// txtDistrict
			// 
			this.txtDistrict.Location = new System.Drawing.Point(21, 59);
			this.txtDistrict.Name = "txtDistrict";
			this.txtDistrict.Size = new System.Drawing.Size(248, 27);
			this.txtDistrict.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddProduct);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtProductName);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtCategory);
			this.groupBox2.Location = new System.Drawing.Point(305, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(283, 331);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Добавление товаров";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(173, 271);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
			this.btnAddProduct.TabIndex = 13;
			this.btnAddProduct.Text = "Добавить";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Категория";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(19, 59);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(248, 27);
			this.txtProductName.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Название";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(19, 115);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(248, 27);
			this.txtCategory.TabIndex = 10;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(494, 349);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// CreateProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 396);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateProducts";
			this.Text = "Добавление товаров и магазинов";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtStoreName;
		private System.Windows.Forms.TextBox txtDistrict;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHouse;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Button btnAddStore;
		private System.Windows.Forms.Button btnAddProduct;
	}
}