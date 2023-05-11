namespace Final_Project_SE
{
	partial class FrmUpdateAgentRequest
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
			this.DGV_currentProduct = new System.Windows.Forms.DataGridView();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.DGV_Export_e = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TB_ReceiptNo_e = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_TargetStockLocation_e = new System.Windows.Forms.TextBox();
			this.TB_TargetStockName_e = new System.Windows.Forms.TextBox();
			this.TB_Reason_e = new System.Windows.Forms.TextBox();
			this.TB_ReceiverName_e = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DGV_ARequest = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DGV_currentProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ARequest)).BeginInit();
			this.SuspendLayout();
			// 
			// DGV_currentProduct
			// 
			this.DGV_currentProduct.AllowUserToAddRows = false;
			this.DGV_currentProduct.AllowUserToDeleteRows = false;
			this.DGV_currentProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_currentProduct.Location = new System.Drawing.Point(391, 405);
			this.DGV_currentProduct.MultiSelect = false;
			this.DGV_currentProduct.Name = "DGV_currentProduct";
			this.DGV_currentProduct.ReadOnly = true;
			this.DGV_currentProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_currentProduct.Size = new System.Drawing.Size(612, 151);
			this.DGV_currentProduct.TabIndex = 22;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(838, 562);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(165, 57);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnCommit
			// 
			this.btnCommit.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommit.Location = new System.Drawing.Point(656, 562);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(165, 57);
			this.btnCommit.TabIndex = 19;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = false;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// DGV_Export_e
			// 
			this.DGV_Export_e.AllowUserToAddRows = false;
			this.DGV_Export_e.AllowUserToDeleteRows = false;
			this.DGV_Export_e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Export_e.Location = new System.Drawing.Point(390, 224);
			this.DGV_Export_e.MultiSelect = false;
			this.DGV_Export_e.Name = "DGV_Export_e";
			this.DGV_Export_e.ReadOnly = true;
			this.DGV_Export_e.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_Export_e.Size = new System.Drawing.Size(612, 150);
			this.DGV_Export_e.TabIndex = 18;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.TB_ReceiptNo_e);
			this.groupBox2.Location = new System.Drawing.Point(535, 51);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(332, 41);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(92, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(242, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "No.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Date created";
			// 
			// TB_ReceiptNo_e
			// 
			this.TB_ReceiptNo_e.Location = new System.Drawing.Point(272, 11);
			this.TB_ReceiptNo_e.Name = "TB_ReceiptNo_e";
			this.TB_ReceiptNo_e.Size = new System.Drawing.Size(51, 20);
			this.TB_ReceiptNo_e.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TB_TargetStockLocation_e);
			this.groupBox1.Controls.Add(this.TB_TargetStockName_e);
			this.groupBox1.Controls.Add(this.TB_Reason_e);
			this.groupBox1.Controls.Add(this.TB_ReceiverName_e);
			this.groupBox1.Location = new System.Drawing.Point(390, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 100);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(263, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Location";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Export in stock";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Reason for issuing";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Receiver\'s Full name";
			// 
			// TB_TargetStockLocation_e
			// 
			this.TB_TargetStockLocation_e.Location = new System.Drawing.Point(324, 67);
			this.TB_TargetStockLocation_e.Name = "TB_TargetStockLocation_e";
			this.TB_TargetStockLocation_e.Size = new System.Drawing.Size(267, 20);
			this.TB_TargetStockLocation_e.TabIndex = 6;
			// 
			// TB_TargetStockName_e
			// 
			this.TB_TargetStockName_e.Location = new System.Drawing.Point(164, 67);
			this.TB_TargetStockName_e.Name = "TB_TargetStockName_e";
			this.TB_TargetStockName_e.Size = new System.Drawing.Size(93, 20);
			this.TB_TargetStockName_e.TabIndex = 5;
			// 
			// TB_Reason_e
			// 
			this.TB_Reason_e.Location = new System.Drawing.Point(164, 45);
			this.TB_Reason_e.Name = "TB_Reason_e";
			this.TB_Reason_e.Size = new System.Drawing.Size(427, 20);
			this.TB_Reason_e.TabIndex = 2;
			// 
			// TB_ReceiverName_e
			// 
			this.TB_ReceiverName_e.Location = new System.Drawing.Point(164, 19);
			this.TB_ReceiverName_e.Name = "TB_ReceiverName_e";
			this.TB_ReceiverName_e.Size = new System.Drawing.Size(427, 20);
			this.TB_ReceiverName_e.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(78, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 39);
			this.label1.TabIndex = 15;
			this.label1.Text = "Agent Request";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(578, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(262, 39);
			this.label4.TabIndex = 23;
			this.label4.Text = "Request Details";
			// 
			// DGV_ARequest
			// 
			this.DGV_ARequest.AllowUserToAddRows = false;
			this.DGV_ARequest.AllowUserToDeleteRows = false;
			this.DGV_ARequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_ARequest.Location = new System.Drawing.Point(19, 51);
			this.DGV_ARequest.Name = "DGV_ARequest";
			this.DGV_ARequest.ReadOnly = true;
			this.DGV_ARequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_ARequest.Size = new System.Drawing.Size(365, 568);
			this.DGV_ARequest.TabIndex = 24;
			this.DGV_ARequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_checkInfo);
			this.DGV_ARequest.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CM_checkInfo);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(390, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 16);
			this.label5.TabIndex = 25;
			this.label5.Text = "Agent request product";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(390, 386);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(145, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "Current product in stock";
			// 
			// FrmUpdateAgentRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 631);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.DGV_ARequest);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DGV_currentProduct);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.DGV_Export_e);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "FrmUpdateAgentRequest";
			this.Text = "FrmUpdateAgentRequest";
			this.Load += new System.EventHandler(this.FrmUpdateAgentRequest_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_currentProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ARequest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGV_currentProduct;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.DataGridView DGV_Export_e;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TB_ReceiptNo_e;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_TargetStockLocation_e;
		private System.Windows.Forms.TextBox TB_TargetStockName_e;
		private System.Windows.Forms.TextBox TB_Reason_e;
		private System.Windows.Forms.TextBox TB_ReceiverName_e;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView DGV_ARequest;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
	}
}