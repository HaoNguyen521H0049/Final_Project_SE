namespace Final_Project_SE
{
	partial class frmGoodDeliveryNote
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.DGV_Export_e = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TB_ReceiptNo_e = new System.Windows.Forms.TextBox();
			this.TB_DateCreated_e = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_TargetStockLocation_e = new System.Windows.Forms.TextBox();
			this.TB_TargetStockName_e = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptNo = new System.Windows.Forms.TextBox();
			this.TB_ReceiverName_e = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cb_selectGood_e = new System.Windows.Forms.ComboBox();
			this.tb_ProductColor_e = new System.Windows.Forms.TextBox();
			this.tdks = new System.Windows.Forms.Label();
			this.tb_ProductMemo_e = new System.Windows.Forms.TextBox();
			this.tb_ProductQuantity_e = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(527, 519);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 57);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnCommit
			// 
			this.btnCommit.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommit.Location = new System.Drawing.Point(424, 519);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(97, 57);
			this.btnCommit.TabIndex = 10;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = false;
			// 
			// DGV_Export_e
			// 
			this.DGV_Export_e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Export_e.Location = new System.Drawing.Point(12, 298);
			this.DGV_Export_e.Name = "DGV_Export_e";
			this.DGV_Export_e.Size = new System.Drawing.Size(612, 215);
			this.DGV_Export_e.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.TB_ReceiptNo_e);
			this.groupBox2.Controls.Add(this.TB_DateCreated_e);
			this.groupBox2.Location = new System.Drawing.Point(166, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(314, 41);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(220, 11);
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
			this.TB_ReceiptNo_e.Location = new System.Drawing.Point(254, 11);
			this.TB_ReceiptNo_e.Name = "TB_ReceiptNo_e";
			this.TB_ReceiptNo_e.Size = new System.Drawing.Size(51, 20);
			this.TB_ReceiptNo_e.TabIndex = 1;
			// 
			// TB_DateCreated_e
			// 
			this.TB_DateCreated_e.Location = new System.Drawing.Point(97, 10);
			this.TB_DateCreated_e.Name = "TB_DateCreated_e";
			this.TB_DateCreated_e.Size = new System.Drawing.Size(117, 20);
			this.TB_DateCreated_e.TabIndex = 0;
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
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptNo);
			this.groupBox1.Controls.Add(this.TB_ReceiverName_e);
			this.groupBox1.Location = new System.Drawing.Point(12, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(343, 68);
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
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Receiver\'s Full name";
			// 
			// TB_TargetStockLocation_e
			// 
			this.TB_TargetStockLocation_e.Location = new System.Drawing.Point(407, 67);
			this.TB_TargetStockLocation_e.Name = "TB_TargetStockLocation_e";
			this.TB_TargetStockLocation_e.Size = new System.Drawing.Size(184, 20);
			this.TB_TargetStockLocation_e.TabIndex = 6;
			// 
			// TB_TargetStockName_e
			// 
			this.TB_TargetStockName_e.Location = new System.Drawing.Point(164, 67);
			this.TB_TargetStockName_e.Name = "TB_TargetStockName_e";
			this.TB_TargetStockName_e.Size = new System.Drawing.Size(173, 20);
			this.TB_TargetStockName_e.TabIndex = 5;
			// 
			// TB_AccordingToReceiptNo
			// 
			this.TB_AccordingToReceiptNo.Location = new System.Drawing.Point(164, 45);
			this.TB_AccordingToReceiptNo.Name = "TB_AccordingToReceiptNo";
			this.TB_AccordingToReceiptNo.Size = new System.Drawing.Size(427, 20);
			this.TB_AccordingToReceiptNo.TabIndex = 2;
			// 
			// TB_ReceiverName_e
			// 
			this.TB_ReceiverName_e.Location = new System.Drawing.Point(164, 22);
			this.TB_ReceiverName_e.Name = "TB_ReceiverName_e";
			this.TB_ReceiverName_e.Size = new System.Drawing.Size(427, 20);
			this.TB_ReceiverName_e.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(169, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 39);
			this.label1.TabIndex = 6;
			this.label1.Text = "Warehouse Export";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.tb_ProductColor_e);
			this.groupBox3.Controls.Add(this.tdks);
			this.groupBox3.Controls.Add(this.tb_ProductMemo_e);
			this.groupBox3.Controls.Add(this.tb_ProductQuantity_e);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.cb_selectGood_e);
			this.groupBox3.Location = new System.Drawing.Point(12, 207);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(612, 85);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			// 
			// cb_selectGood_e
			// 
			this.cb_selectGood_e.FormattingEnabled = true;
			this.cb_selectGood_e.Location = new System.Drawing.Point(9, 47);
			this.cb_selectGood_e.Name = "cb_selectGood_e";
			this.cb_selectGood_e.Size = new System.Drawing.Size(289, 21);
			this.cb_selectGood_e.TabIndex = 13;
			// 
			// tb_ProductColor_e
			// 
			this.tb_ProductColor_e.Location = new System.Drawing.Point(393, 48);
			this.tb_ProductColor_e.Name = "tb_ProductColor_e";
			this.tb_ProductColor_e.Size = new System.Drawing.Size(209, 20);
			this.tb_ProductColor_e.TabIndex = 20;
			// 
			// tdks
			// 
			this.tdks.AutoSize = true;
			this.tdks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tdks.Location = new System.Drawing.Point(318, 48);
			this.tdks.Name = "tdks";
			this.tdks.Size = new System.Drawing.Size(39, 16);
			this.tdks.TabIndex = 19;
			this.tdks.Text = "Color";
			// 
			// tb_ProductMemo_e
			// 
			this.tb_ProductMemo_e.Location = new System.Drawing.Point(536, 15);
			this.tb_ProductMemo_e.Name = "tb_ProductMemo_e";
			this.tb_ProductMemo_e.Size = new System.Drawing.Size(66, 20);
			this.tb_ProductMemo_e.TabIndex = 18;
			// 
			// tb_ProductQuantity_e
			// 
			this.tb_ProductQuantity_e.Location = new System.Drawing.Point(393, 15);
			this.tb_ProductQuantity_e.Name = "tb_ProductQuantity_e";
			this.tb_ProductQuantity_e.Size = new System.Drawing.Size(75, 20);
			this.tb_ProductQuantity_e.TabIndex = 17;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(474, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 16;
			this.label12.Text = "Memory";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(318, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 16);
			this.label10.TabIndex = 15;
			this.label10.Text = "Quantity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Select Product";
			// 
			// frmGoodDeliveryNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 584);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.DGV_Export_e);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmGoodDeliveryNote";
			this.Text = "frmGoodDeliveryNote";
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.DataGridView DGV_Export_e;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TB_ReceiptNo_e;
		private System.Windows.Forms.TextBox TB_DateCreated_e;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_TargetStockLocation_e;
		private System.Windows.Forms.TextBox TB_TargetStockName_e;
		private System.Windows.Forms.TextBox TB_AccordingToReceiptNo;
		private System.Windows.Forms.TextBox TB_ReceiverName_e;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cb_selectGood_e;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_ProductColor_e;
		private System.Windows.Forms.Label tdks;
		private System.Windows.Forms.TextBox tb_ProductMemo_e;
		private System.Windows.Forms.TextBox tb_ProductQuantity_e;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
	}
}