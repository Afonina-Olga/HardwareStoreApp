namespace HardwareStoreApp
{
	partial class SalesForm
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
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbStore = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbProduct = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
			this.bsStore = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.txtSaleCount = new System.Windows.Forms.TextBox();
			this.dtSaleDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStore)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPrice
			// 
			this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
			this.txtPrice.Enabled = false;
			this.txtPrice.Location = new System.Drawing.Point(12, 193);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(402, 27);
			this.txtPrice.TabIndex = 0;
			this.txtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Магазин";
			// 
			// cbStore
			// 
			this.cbStore.FormattingEnabled = true;
			this.cbStore.Location = new System.Drawing.Point(12, 32);
			this.cbStore.Name = "cbStore";
			this.cbStore.Size = new System.Drawing.Size(402, 28);
			this.cbStore.TabIndex = 2;
			this.cbStore.SelectedIndexChanged += new System.EventHandler(this.CbStore_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Товар";
			// 
			// cbProduct
			// 
			this.cbProduct.FormattingEnabled = true;
			this.cbProduct.Location = new System.Drawing.Point(12, 86);
			this.cbProduct.Name = "cbProduct";
			this.cbProduct.Size = new System.Drawing.Size(402, 28);
			this.cbProduct.TabIndex = 4;
			this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.CbProduct_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Цена";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "В наличии";
			// 
			// txtBalance
			// 
			this.txtBalance.BackColor = System.Drawing.SystemColors.Window;
			this.txtBalance.Enabled = false;
			this.txtBalance.Location = new System.Drawing.Point(12, 140);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.ReadOnly = true;
			this.txtBalance.Size = new System.Drawing.Size(402, 27);
			this.txtBalance.TabIndex = 6;
			this.txtBalance.TextChanged += new System.EventHandler(this.TxtBalance_TextChanged);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(12, 338);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(402, 29);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Куплено, шт.";
			// 
			// txtSaleCount
			// 
			this.txtSaleCount.Location = new System.Drawing.Point(12, 299);
			this.txtSaleCount.Name = "txtSaleCount";
			this.txtSaleCount.Size = new System.Drawing.Size(402, 27);
			this.txtSaleCount.TabIndex = 9;
			// 
			// dtSaleDate
			// 
			this.dtSaleDate.Location = new System.Drawing.Point(12, 246);
			this.dtSaleDate.Name = "dtSaleDate";
			this.dtSaleDate.Size = new System.Drawing.Size(401, 27);
			this.dtSaleDate.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Дата покупки";
			// 
			// SalesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 379);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtSaleDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSaleCount);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbProduct);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbStore);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPrice);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SalesForm";
			this.Text = "Продажа товара";
			this.Load += new System.EventHandler(this.SalesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbStore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbProduct;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.BindingSource bsProduct;
		private System.Windows.Forms.BindingSource bsStore;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSaleCount;
		private System.Windows.Forms.DateTimePicker dtSaleDate;
		private System.Windows.Forms.Label label6;
	}
}