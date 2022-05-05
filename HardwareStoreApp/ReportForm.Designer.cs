namespace HardwareStoreApp
{
	partial class ReportForm
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
			this.cbStore = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtStart = new System.Windows.Forms.DateTimePicker();
			this.dtEnd = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReport = new System.Windows.Forms.RichTextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.bsStores = new System.Windows.Forms.BindingSource(this.components);
			this.btnCreate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bsStores)).BeginInit();
			this.SuspendLayout();
			// 
			// cbStore
			// 
			this.cbStore.FormattingEnabled = true;
			this.cbStore.Location = new System.Drawing.Point(119, 21);
			this.cbStore.Name = "cbStore";
			this.cbStore.Size = new System.Drawing.Size(374, 28);
			this.cbStore.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Магазин";
			// 
			// dtStart
			// 
			this.dtStart.Location = new System.Drawing.Point(119, 67);
			this.dtStart.Name = "dtStart";
			this.dtStart.Size = new System.Drawing.Size(184, 27);
			this.dtStart.TabIndex = 2;
			// 
			// dtEnd
			// 
			this.dtEnd.Location = new System.Drawing.Point(309, 67);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.Size = new System.Drawing.Size(184, 27);
			this.dtEnd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Период";
			// 
			// txtReport
			// 
			this.txtReport.Location = new System.Drawing.Point(119, 113);
			this.txtReport.Name = "txtReport";
			this.txtReport.Size = new System.Drawing.Size(374, 264);
			this.txtReport.TabIndex = 5;
			this.txtReport.Text = "";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(399, 394);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(259, 394);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(134, 29);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "Сформировать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 444);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtReport);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtEnd);
			this.Controls.Add(this.dtStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbStore);
			this.Name = "ReportForm";
			this.Text = "Отчеты";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsStores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbStore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtStart;
		private System.Windows.Forms.DateTimePicker dtEnd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtReport;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.BindingSource bsStores;
		private System.Windows.Forms.Button btnCreate;
	}
}