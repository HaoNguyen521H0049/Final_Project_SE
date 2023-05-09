namespace Final_Project_SE
{
	partial class FrmProductReport
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
			this.Cb_selection = new System.Windows.Forms.ComboBox();
			this.DGV_selected_option = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_selected_option)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Cb_selection);
			this.groupBox1.Controls.Add(this.DGV_selected_option);
			this.groupBox1.Location = new System.Drawing.Point(12, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 424);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Product Sold";
			// 
			// Cb_selection
			// 
			this.Cb_selection.FormattingEnabled = true;
			this.Cb_selection.Location = new System.Drawing.Point(649, 17);
			this.Cb_selection.Name = "Cb_selection";
			this.Cb_selection.Size = new System.Drawing.Size(121, 21);
			this.Cb_selection.TabIndex = 1;
			this.Cb_selection.SelectedIndexChanged += new System.EventHandler(this.Cb_selection_SelectedIndexChanged);
			// 
			// DGV_selected_option
			// 
			this.DGV_selected_option.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_selected_option.Location = new System.Drawing.Point(6, 44);
			this.DGV_selected_option.Name = "DGV_selected_option";
			this.DGV_selected_option.Size = new System.Drawing.Size(764, 374);
			this.DGV_selected_option.TabIndex = 0;
			// 
			// frmProductReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmProductReport";
			this.Text = "frmProductReport";
			this.Load += new System.EventHandler(this.frmProductReport_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_selected_option)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView DGV_selected_option;
		private System.Windows.Forms.ComboBox Cb_selection;
	}
}