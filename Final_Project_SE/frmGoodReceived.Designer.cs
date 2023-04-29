namespace Final_Project_SE
{
	partial class frmGoodReceived
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_TargetStockLocation_i = new System.Windows.Forms.TextBox();
			this.TB_TargetStockName_i = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptComp_Name_i = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptDMY_i = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptNo_i = new System.Windows.Forms.TextBox();
			this.TB_DeliverName_i = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TB_ReceiptNo_i = new System.Windows.Forms.TextBox();
			this.TB_DateCreated_i = new System.Windows.Forms.TextBox();
			this.DGV_Receipt_i = new System.Windows.Forms.DataGridView();
			this.btnCommit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Check_neverExist = new System.Windows.Forms.CheckBox();
			this.Check_existOnce = new System.Windows.Forms.CheckBox();
			this.tb_addProduct_i = new System.Windows.Forms.TextBox();
			this.cb_selectGood_i = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tb_ProductColor = new System.Windows.Forms.TextBox();
			this.tdks = new System.Windows.Forms.Label();
			this.tb_ProductMemo = new System.Windows.Forms.TextBox();
			this.tb_ProductID_i = new System.Windows.Forms.TextBox();
			this.tb_ProductQuantity_i = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_i)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Warehouse Receipt";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TB_TargetStockLocation_i);
			this.groupBox1.Controls.Add(this.TB_TargetStockName_i);
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptComp_Name_i);
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptDMY_i);
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptNo_i);
			this.groupBox1.Controls.Add(this.TB_DeliverName_i);
			this.groupBox1.Location = new System.Drawing.Point(12, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 100);
			this.groupBox1.TabIndex = 1;
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
			this.label6.Size = new System.Drawing.Size(92, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Import in stock";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(381, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Of";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(233, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "D/M/Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "According to receipt No.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Deliver\'s Full name";
			// 
			// TB_TargetStockLocation_i
			// 
			this.TB_TargetStockLocation_i.Location = new System.Drawing.Point(407, 67);
			this.TB_TargetStockLocation_i.Name = "TB_TargetStockLocation_i";
			this.TB_TargetStockLocation_i.Size = new System.Drawing.Size(184, 20);
			this.TB_TargetStockLocation_i.TabIndex = 6;
			// 
			// TB_TargetStockName_i
			// 
			this.TB_TargetStockName_i.Location = new System.Drawing.Point(164, 67);
			this.TB_TargetStockName_i.Name = "TB_TargetStockName_i";
			this.TB_TargetStockName_i.Size = new System.Drawing.Size(173, 20);
			this.TB_TargetStockName_i.TabIndex = 5;
			// 
			// TB_AccordingToReceiptComp_Name_i
			// 
			this.TB_AccordingToReceiptComp_Name_i.Location = new System.Drawing.Point(407, 45);
			this.TB_AccordingToReceiptComp_Name_i.Name = "TB_AccordingToReceiptComp_Name_i";
			this.TB_AccordingToReceiptComp_Name_i.Size = new System.Drawing.Size(184, 20);
			this.TB_AccordingToReceiptComp_Name_i.TabIndex = 4;
			// 
			// TB_AccordingToReceiptDMY_i
			// 
			this.TB_AccordingToReceiptDMY_i.Location = new System.Drawing.Point(284, 45);
			this.TB_AccordingToReceiptDMY_i.Name = "TB_AccordingToReceiptDMY_i";
			this.TB_AccordingToReceiptDMY_i.Size = new System.Drawing.Size(91, 20);
			this.TB_AccordingToReceiptDMY_i.TabIndex = 3;
			// 
			// TB_AccordingToReceiptNo_i
			// 
			this.TB_AccordingToReceiptNo_i.Location = new System.Drawing.Point(164, 45);
			this.TB_AccordingToReceiptNo_i.Name = "TB_AccordingToReceiptNo_i";
			this.TB_AccordingToReceiptNo_i.Size = new System.Drawing.Size(63, 20);
			this.TB_AccordingToReceiptNo_i.TabIndex = 2;
			// 
			// TB_DeliverName_i
			// 
			this.TB_DeliverName_i.Location = new System.Drawing.Point(164, 22);
			this.TB_DeliverName_i.Name = "TB_DeliverName_i";
			this.TB_DeliverName_i.Size = new System.Drawing.Size(427, 20);
			this.TB_DeliverName_i.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.TB_ReceiptNo_i);
			this.groupBox2.Controls.Add(this.TB_DateCreated_i);
			this.groupBox2.Location = new System.Drawing.Point(166, 51);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(314, 41);
			this.groupBox2.TabIndex = 2;
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
			// TB_ReceiptNo_i
			// 
			this.TB_ReceiptNo_i.Location = new System.Drawing.Point(254, 11);
			this.TB_ReceiptNo_i.Name = "TB_ReceiptNo_i";
			this.TB_ReceiptNo_i.Size = new System.Drawing.Size(51, 20);
			this.TB_ReceiptNo_i.TabIndex = 1;
			// 
			// TB_DateCreated_i
			// 
			this.TB_DateCreated_i.Location = new System.Drawing.Point(97, 10);
			this.TB_DateCreated_i.Name = "TB_DateCreated_i";
			this.TB_DateCreated_i.Size = new System.Drawing.Size(117, 20);
			this.TB_DateCreated_i.TabIndex = 0;
			// 
			// DGV_Receipt_i
			// 
			this.DGV_Receipt_i.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Receipt_i.Location = new System.Drawing.Point(12, 306);
			this.DGV_Receipt_i.Name = "DGV_Receipt_i";
			this.DGV_Receipt_i.Size = new System.Drawing.Size(612, 205);
			this.DGV_Receipt_i.TabIndex = 3;
			// 
			// btnCommit
			// 
			this.btnCommit.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommit.Location = new System.Drawing.Point(424, 517);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(97, 57);
			this.btnCommit.TabIndex = 4;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(527, 517);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 57);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox3.Controls.Add(this.Check_neverExist);
			this.groupBox3.Controls.Add(this.Check_existOnce);
			this.groupBox3.Controls.Add(this.tb_addProduct_i);
			this.groupBox3.Controls.Add(this.tb_ProductID_i);
			this.groupBox3.Controls.Add(this.cb_selectGood_i);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Location = new System.Drawing.Point(12, 204);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(307, 96);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			// 
			// Check_neverExist
			// 
			this.Check_neverExist.AutoSize = true;
			this.Check_neverExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_neverExist.Location = new System.Drawing.Point(6, 38);
			this.Check_neverExist.Name = "Check_neverExist";
			this.Check_neverExist.Size = new System.Drawing.Size(78, 20);
			this.Check_neverExist.TabIndex = 5;
			this.Check_neverExist.Text = "Add new";
			this.Check_neverExist.UseVisualStyleBackColor = true;
			// 
			// Check_existOnce
			// 
			this.Check_existOnce.AutoSize = true;
			this.Check_existOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_existOnce.Location = new System.Drawing.Point(6, 12);
			this.Check_existOnce.Name = "Check_existOnce";
			this.Check_existOnce.Size = new System.Drawing.Size(108, 20);
			this.Check_existOnce.TabIndex = 4;
			this.Check_existOnce.Text = "Select Goods";
			this.Check_existOnce.UseVisualStyleBackColor = true;
			// 
			// tb_addProduct_i
			// 
			this.tb_addProduct_i.Location = new System.Drawing.Point(120, 38);
			this.tb_addProduct_i.Name = "tb_addProduct_i";
			this.tb_addProduct_i.Size = new System.Drawing.Size(181, 20);
			this.tb_addProduct_i.TabIndex = 2;
			// 
			// cb_selectGood_i
			// 
			this.cb_selectGood_i.FormattingEnabled = true;
			this.cb_selectGood_i.Location = new System.Drawing.Point(120, 11);
			this.cb_selectGood_i.Name = "cb_selectGood_i";
			this.cb_selectGood_i.Size = new System.Drawing.Size(181, 21);
			this.cb_selectGood_i.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox4.Controls.Add(this.btnAdd);
			this.groupBox4.Controls.Add(this.tb_ProductColor);
			this.groupBox4.Controls.Add(this.tdks);
			this.groupBox4.Controls.Add(this.tb_ProductMemo);
			this.groupBox4.Controls.Add(this.tb_ProductQuantity_i);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Location = new System.Drawing.Point(328, 204);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(296, 96);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			// 
			// tb_ProductColor
			// 
			this.tb_ProductColor.Location = new System.Drawing.Point(81, 38);
			this.tb_ProductColor.Name = "tb_ProductColor";
			this.tb_ProductColor.Size = new System.Drawing.Size(209, 20);
			this.tb_ProductColor.TabIndex = 7;
			// 
			// tdks
			// 
			this.tdks.AutoSize = true;
			this.tdks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tdks.Location = new System.Drawing.Point(6, 39);
			this.tdks.Name = "tdks";
			this.tdks.Size = new System.Drawing.Size(39, 16);
			this.tdks.TabIndex = 6;
			this.tdks.Text = "Color";
			// 
			// tb_ProductMemo
			// 
			this.tb_ProductMemo.Location = new System.Drawing.Point(224, 15);
			this.tb_ProductMemo.Name = "tb_ProductMemo";
			this.tb_ProductMemo.Size = new System.Drawing.Size(66, 20);
			this.tb_ProductMemo.TabIndex = 5;
			// 
			// tb_ProductID_i
			// 
			this.tb_ProductID_i.Location = new System.Drawing.Point(120, 64);
			this.tb_ProductID_i.Name = "tb_ProductID_i";
			this.tb_ProductID_i.Size = new System.Drawing.Size(181, 20);
			this.tb_ProductID_i.TabIndex = 4;
			// 
			// tb_ProductQuantity_i
			// 
			this.tb_ProductQuantity_i.Location = new System.Drawing.Point(81, 15);
			this.tb_ProductQuantity_i.Name = "tb_ProductQuantity_i";
			this.tb_ProductQuantity_i.Size = new System.Drawing.Size(75, 20);
			this.tb_ProductQuantity_i.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(162, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 2;
			this.label12.Text = "Memory";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 65);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 16);
			this.label11.TabIndex = 1;
			this.label11.Text = "Product ID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "Quantity";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(81, 64);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(209, 26);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// frmGoodReceived
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 586);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.DGV_Receipt_i);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmGoodReceived";
			this.Text = "frmGoodReceiver";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_i)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_TargetStockLocation_i;
		private System.Windows.Forms.TextBox TB_TargetStockName_i;
		private System.Windows.Forms.TextBox TB_AccordingToReceiptComp_Name_i;
		private System.Windows.Forms.TextBox TB_AccordingToReceiptDMY_i;
		private System.Windows.Forms.TextBox TB_AccordingToReceiptNo_i;
		private System.Windows.Forms.TextBox TB_DeliverName_i;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TB_ReceiptNo_i;
		private System.Windows.Forms.TextBox TB_DateCreated_i;
		private System.Windows.Forms.DataGridView DGV_Receipt_i;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox Check_neverExist;
		private System.Windows.Forms.CheckBox Check_existOnce;
		private System.Windows.Forms.TextBox tb_addProduct_i;
		private System.Windows.Forms.ComboBox cb_selectGood_i;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox tb_ProductColor;
		private System.Windows.Forms.Label tdks;
		private System.Windows.Forms.TextBox tb_ProductMemo;
		private System.Windows.Forms.TextBox tb_ProductID_i;
		private System.Windows.Forms.TextBox tb_ProductQuantity_i;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAdd;
	}
}