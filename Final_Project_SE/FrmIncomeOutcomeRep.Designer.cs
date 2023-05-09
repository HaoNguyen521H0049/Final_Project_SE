namespace Final_Project_SE
{
	partial class FrmIncomeOutcomeRep
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
			this.DGV_income_data = new System.Windows.Forms.DataGridView();
			this.DGV_income_receipt = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DGV_outcome_data = new System.Windows.Forms.DataGridView();
			this.DGV_outcome_receipt = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_income_data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_income_receipt)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_outcome_data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_outcome_receipt)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DGV_income_data);
			this.groupBox1.Controls.Add(this.DGV_income_receipt);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(525, 420);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Income Stock";
			// 
			// DGV_income_data
			// 
			this.DGV_income_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_income_data.Location = new System.Drawing.Point(6, 230);
			this.DGV_income_data.Name = "DGV_income_data";
			this.DGV_income_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_income_data.Size = new System.Drawing.Size(513, 184);
			this.DGV_income_data.TabIndex = 1;
			// 
			// DGV_income_receipt
			// 
			this.DGV_income_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_income_receipt.Location = new System.Drawing.Point(6, 19);
			this.DGV_income_receipt.Name = "DGV_income_receipt";
			this.DGV_income_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_income_receipt.Size = new System.Drawing.Size(513, 205);
			this.DGV_income_receipt.TabIndex = 0;
			this.DGV_income_receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cc_income_data);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DGV_outcome_data);
			this.groupBox2.Controls.Add(this.DGV_outcome_receipt);
			this.groupBox2.Location = new System.Drawing.Point(543, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(525, 420);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Outcome Stock";
			// 
			// DGV_outcome_data
			// 
			this.DGV_outcome_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_outcome_data.Location = new System.Drawing.Point(6, 230);
			this.DGV_outcome_data.Name = "DGV_outcome_data";
			this.DGV_outcome_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_outcome_data.Size = new System.Drawing.Size(513, 184);
			this.DGV_outcome_data.TabIndex = 2;
			// 
			// DGV_outcome_receipt
			// 
			this.DGV_outcome_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_outcome_receipt.Location = new System.Drawing.Point(6, 19);
			this.DGV_outcome_receipt.Name = "DGV_outcome_receipt";
			this.DGV_outcome_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_outcome_receipt.Size = new System.Drawing.Size(513, 205);
			this.DGV_outcome_receipt.TabIndex = 1;
			this.DGV_outcome_receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cc_outcome_data);
			// 
			// frmIncomeOutcomeRep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 444);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmIncomeOutcomeRep";
			this.Text = "frmIncomeOutcomeRep";
			this.Load += new System.EventHandler(this.frmIncomeOutcomeRep_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_income_data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_income_receipt)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_outcome_data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_outcome_receipt)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView DGV_income_receipt;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView DGV_income_data;
		private System.Windows.Forms.DataGridView DGV_outcome_receipt;
		private System.Windows.Forms.DataGridView DGV_outcome_data;
	}
}