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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TB_ReceiptNo_e = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cb_receiver_e = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_TargetStockLocation_e = new System.Windows.Forms.TextBox();
			this.TB_TargetStockName_e = new System.Windows.Forms.TextBox();
			this.TB_Reason_e = new System.Windows.Forms.TextBox();
			this.TB_ReceiverName_e = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cb_memo_e = new System.Windows.Forms.ComboBox();
			this.cb_color_e = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tdks = new System.Windows.Forms.Label();
			this.tb_ProductQuantity_e = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cb_selectGood_e = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.checkIfNew = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// DGV_Export_e
			// 
			this.DGV_Export_e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Export_e.Location = new System.Drawing.Point(12, 280);
			this.DGV_Export_e.Name = "DGV_Export_e";
			this.DGV_Export_e.Size = new System.Drawing.Size(612, 166);
			this.DGV_Export_e.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.TB_ReceiptNo_e);
			this.groupBox2.Location = new System.Drawing.Point(157, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(332, 41);
			this.groupBox2.TabIndex = 8;
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
			this.TB_ReceiptNo_e.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_RNo_Change);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.checkIfNew);
			this.groupBox1.Controls.Add(this.cb_receiver_e);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TB_TargetStockLocation_e);
			this.groupBox1.Controls.Add(this.TB_TargetStockName_e);
			this.groupBox1.Controls.Add(this.TB_Reason_e);
			this.groupBox1.Controls.Add(this.TB_ReceiverName_e);
			this.groupBox1.Location = new System.Drawing.Point(12, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// cb_receiver_e
			// 
			this.cb_receiver_e.FormattingEnabled = true;
			this.cb_receiver_e.Location = new System.Drawing.Point(164, 19);
			this.cb_receiver_e.Name = "cb_receiver_e";
			this.cb_receiver_e.Size = new System.Drawing.Size(178, 21);
			this.cb_receiver_e.TabIndex = 13;
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
			this.TB_ReceiverName_e.Location = new System.Drawing.Point(418, 19);
			this.TB_ReceiverName_e.Name = "TB_ReceiverName_e";
			this.TB_ReceiverName_e.Size = new System.Drawing.Size(173, 20);
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
			this.groupBox3.Controls.Add(this.cb_memo_e);
			this.groupBox3.Controls.Add(this.cb_color_e);
			this.groupBox3.Controls.Add(this.btnAdd);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.tdks);
			this.groupBox3.Controls.Add(this.tb_ProductQuantity_e);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.cb_selectGood_e);
			this.groupBox3.Location = new System.Drawing.Point(12, 207);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(612, 67);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			// 
			// cb_memo_e
			// 
			this.cb_memo_e.FormattingEnabled = true;
			this.cb_memo_e.Location = new System.Drawing.Point(254, 35);
			this.cb_memo_e.Name = "cb_memo_e";
			this.cb_memo_e.Size = new System.Drawing.Size(88, 21);
			this.cb_memo_e.TabIndex = 23;
			this.cb_memo_e.SelectedIndexChanged += new System.EventHandler(this.cb_memo_e_SelectedIndexChanged);
			// 
			// cb_color_e
			// 
			this.cb_color_e.FormattingEnabled = true;
			this.cb_color_e.Location = new System.Drawing.Point(106, 35);
			this.cb_color_e.Name = "cb_color_e";
			this.cb_color_e.Size = new System.Drawing.Size(89, 21);
			this.cb_color_e.TabIndex = 22;
			this.cb_color_e.SelectedIndexChanged += new System.EventHandler(this.cb_color_e_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(457, 11);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(149, 44);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Select Product";
			// 
			// tdks
			// 
			this.tdks.AutoSize = true;
			this.tdks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tdks.Location = new System.Drawing.Point(6, 36);
			this.tdks.Name = "tdks";
			this.tdks.Size = new System.Drawing.Size(39, 16);
			this.tdks.TabIndex = 19;
			this.tdks.Text = "Color";
			// 
			// tb_ProductQuantity_e
			// 
			this.tb_ProductQuantity_e.Location = new System.Drawing.Point(402, 36);
			this.tb_ProductQuantity_e.Name = "tb_ProductQuantity_e";
			this.tb_ProductQuantity_e.Size = new System.Drawing.Size(39, 20);
			this.tb_ProductQuantity_e.TabIndex = 17;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(201, 36);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 16;
			this.label12.Text = "Memory";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(341, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 16);
			this.label10.TabIndex = 15;
			this.label10.Text = "Quantity";
			// 
			// cb_selectGood_e
			// 
			this.cb_selectGood_e.FormattingEnabled = true;
			this.cb_selectGood_e.Location = new System.Drawing.Point(106, 11);
			this.cb_selectGood_e.Name = "cb_selectGood_e";
			this.cb_selectGood_e.Size = new System.Drawing.Size(335, 21);
			this.cb_selectGood_e.TabIndex = 13;
			this.cb_selectGood_e.SelectedIndexChanged += new System.EventHandler(this.cb_selectGood_e_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 452);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(612, 61);
			this.dataGridView1.TabIndex = 13;
			// 
			// checkIfNew
			// 
			this.checkIfNew.AutoSize = true;
			this.checkIfNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkIfNew.Location = new System.Drawing.Point(359, 19);
			this.checkIfNew.Name = "checkIfNew";
			this.checkIfNew.Size = new System.Drawing.Size(53, 20);
			this.checkIfNew.TabIndex = 15;
			this.checkIfNew.Text = "New";
			this.checkIfNew.UseVisualStyleBackColor = true;
			this.checkIfNew.CheckedChanged += new System.EventHandler(this.checkIfNew_CheckedChanged);
			// 
			// frmGoodDeliveryNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 584);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.DGV_Export_e);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmGoodDeliveryNote";
			this.Text = "frmGoodDeliveryNote";
			this.Load += new System.EventHandler(this.frmGoodDeliveryNote_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_Export_e)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cb_selectGood_e;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label tdks;
		private System.Windows.Forms.TextBox tb_ProductQuantity_e;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cb_memo_e;
		private System.Windows.Forms.ComboBox cb_color_e;
		private System.Windows.Forms.ComboBox cb_receiver_e;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.CheckBox checkIfNew;
	}
}