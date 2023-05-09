namespace Final_Project_SE
{
	partial class FrmMonthlySell
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
			this.DGV_ShowData = new System.Windows.Forms.DataGridView();
			this.DGV_Receipt = new System.Windows.Forms.DataGridView();
			this.DGV_Product = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ShowData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.DGV_Product);
			this.groupBox1.Controls.Add(this.DGV_Receipt);
			this.groupBox1.Controls.Add(this.DGV_ShowData);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 426);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Monthly seller";
			// 
			// DGV_ShowData
			// 
			this.DGV_ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_ShowData.Location = new System.Drawing.Point(6, 73);
			this.DGV_ShowData.Name = "DGV_ShowData";
			this.DGV_ShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_ShowData.Size = new System.Drawing.Size(263, 338);
			this.DGV_ShowData.TabIndex = 0;
			this.DGV_ShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_monthSelected);
			// 
			// DGV_Receipt
			// 
			this.DGV_Receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Receipt.Location = new System.Drawing.Point(275, 73);
			this.DGV_Receipt.Name = "DGV_Receipt";
			this.DGV_Receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_Receipt.Size = new System.Drawing.Size(495, 143);
			this.DGV_Receipt.TabIndex = 3;
			this.DGV_Receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_Receipt_selected);
			// 
			// DGV_Product
			// 
			this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Product.Location = new System.Drawing.Point(275, 238);
			this.DGV_Product.Name = "DGV_Product";
			this.DGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_Product.Size = new System.Drawing.Size(495, 173);
			this.DGV_Product.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Month";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(272, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Receipt in month";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(275, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Product sold in month";
			// 
			// FrmMonthlySell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmMonthlySell";
			this.Text = "FrmMonthlySell";
			this.Load += new System.EventHandler(this.FrmMonthlySell_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ShowData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView DGV_ShowData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView DGV_Product;
		private System.Windows.Forms.DataGridView DGV_Receipt;
	}
}