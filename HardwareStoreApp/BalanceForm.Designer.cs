namespace HardwareStoreApp
{
	partial class BalanceForm
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
			this.cbProduct = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbStore = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
			this.bsStore = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStore)).BeginInit();
			this.SuspendLayout();
			// 
			// cbProduct
			// 
			this.cbProduct.FormattingEnabled = true;
			this.cbProduct.Location = new System.Drawing.Point(12, 32);
			this.cbProduct.Name = "cbProduct";
			this.cbProduct.Size = new System.Drawing.Size(312, 28);
			this.cbProduct.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Продукт";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Магазин";
			// 
			// cbStore
			// 
			this.cbStore.FormattingEnabled = true;
			this.cbStore.Location = new System.Drawing.Point(12, 88);
			this.cbStore.Name = "cbStore";
			this.cbStore.Size = new System.Drawing.Size(312, 28);
			this.cbStore.TabIndex = 2;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(12, 144);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(312, 27);
			this.txtPrice.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Цена";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Количество";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(12, 199);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(312, 27);
			this.txtCount.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 247);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(312, 29);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Принять";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BalanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 291);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbStore);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbProduct);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BalanceForm";
			this.Text = "Приемка товара";
			this.Load += new System.EventHandler(this.BalanceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsStore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbStore;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.BindingSource bsProduct;
		private System.Windows.Forms.BindingSource bsStore;
	}
}