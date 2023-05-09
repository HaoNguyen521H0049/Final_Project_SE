namespace Final_Project_SE
{
	partial class FrmGoodReceived
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodReceived));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.cb_receiver_i = new System.Windows.Forms.ComboBox();
			this.checkIfNew = new System.Windows.Forms.CheckBox();
			this.TB_ReceiverName_i = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_TargetStockLocation_i = new System.Windows.Forms.TextBox();
			this.TB_TargetStockName_i = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptComp_Name_i = new System.Windows.Forms.TextBox();
			this.TB_AccordingToReceiptNo_i = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TB_ReceiptNo_i = new System.Windows.Forms.TextBox();
			this.DGV_Receipt_i = new System.Windows.Forms.DataGridView();
			this.btnCommit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.Check_neverExist = new System.Windows.Forms.CheckBox();
			this.tb_addProduct_i = new System.Windows.Forms.TextBox();
			this.tb_ProductID_i = new System.Windows.Forms.TextBox();
			this.cb_selectGood_i = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_ProductQuantity_i = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tb_Price_i = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tb_ProductColor = new System.Windows.Forms.TextBox();
			this.tdks = new System.Windows.Forms.Label();
			this.tb_ProductMemo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.cb_memo_i = new System.Windows.Forms.ComboBox();
			this.cb_color_i = new System.Windows.Forms.ComboBox();
			this.tb_Price_i_old = new System.Windows.Forms.TextBox();
			this.tb_Quant_i_old = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_i)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.cb_receiver_i);
			this.groupBox1.Controls.Add(this.checkIfNew);
			this.groupBox1.Controls.Add(this.TB_ReceiverName_i);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TB_TargetStockLocation_i);
			this.groupBox1.Controls.Add(this.TB_TargetStockName_i);
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptComp_Name_i);
			this.groupBox1.Controls.Add(this.TB_AccordingToReceiptNo_i);
			this.groupBox1.Location = new System.Drawing.Point(12, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(279, 45);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker2.TabIndex = 15;
			// 
			// cb_receiver_i
			// 
			this.cb_receiver_i.FormattingEnabled = true;
			this.cb_receiver_i.Location = new System.Drawing.Point(164, 18);
			this.cb_receiver_i.Name = "cb_receiver_i";
			this.cb_receiver_i.Size = new System.Drawing.Size(178, 21);
			this.cb_receiver_i.TabIndex = 17;
			// 
			// checkIfNew
			// 
			this.checkIfNew.AutoSize = true;
			this.checkIfNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkIfNew.Location = new System.Drawing.Point(359, 19);
			this.checkIfNew.Name = "checkIfNew";
			this.checkIfNew.Size = new System.Drawing.Size(53, 20);
			this.checkIfNew.TabIndex = 16;
			this.checkIfNew.Text = "New";
			this.checkIfNew.UseVisualStyleBackColor = true;
			this.checkIfNew.CheckedChanged += new System.EventHandler(this.checkIfNew_CheckedChanged);
			// 
			// TB_ReceiverName_i
			// 
			this.TB_ReceiverName_i.Location = new System.Drawing.Point(418, 19);
			this.TB_ReceiverName_i.Name = "TB_ReceiverName_i";
			this.TB_ReceiverName_i.Size = new System.Drawing.Size(173, 20);
			this.TB_ReceiverName_i.TabIndex = 13;
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
			// TB_AccordingToReceiptNo_i
			// 
			this.TB_AccordingToReceiptNo_i.Location = new System.Drawing.Point(164, 45);
			this.TB_AccordingToReceiptNo_i.Name = "TB_AccordingToReceiptNo_i";
			this.TB_AccordingToReceiptNo_i.Size = new System.Drawing.Size(63, 20);
			this.TB_AccordingToReceiptNo_i.TabIndex = 2;
			this.TB_AccordingToReceiptNo_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATRN_KP);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.TB_ReceiptNo_i);
			this.groupBox2.Location = new System.Drawing.Point(157, 51);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(323, 41);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(91, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(248, 12);
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
			this.TB_ReceiptNo_i.Location = new System.Drawing.Point(278, 11);
			this.TB_ReceiptNo_i.Name = "TB_ReceiptNo_i";
			this.TB_ReceiptNo_i.Size = new System.Drawing.Size(35, 20);
			this.TB_ReceiptNo_i.TabIndex = 1;
			this.TB_ReceiptNo_i.TextChanged += new System.EventHandler(this.TB_ReceiptNo_i_TextChanged);
			this.TB_ReceiptNo_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RNo_KP);
			// 
			// DGV_Receipt_i
			// 
			this.DGV_Receipt_i.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Receipt_i.Location = new System.Drawing.Point(12, 389);
			this.DGV_Receipt_i.Name = "DGV_Receipt_i";
			this.DGV_Receipt_i.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_Receipt_i.Size = new System.Drawing.Size(612, 136);
			this.DGV_Receipt_i.TabIndex = 3;
			// 
			// btnCommit
			// 
			this.btnCommit.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommit.Location = new System.Drawing.Point(424, 600);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(97, 57);
			this.btnCommit.TabIndex = 4;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = false;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(527, 600);
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
			this.groupBox3.Controls.Add(this.tb_Price_i);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.Check_neverExist);
			this.groupBox3.Controls.Add(this.tb_ProductColor);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.tdks);
			this.groupBox3.Controls.Add(this.tb_addProduct_i);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.tb_ProductID_i);
			this.groupBox3.Controls.Add(this.tb_ProductMemo);
			this.groupBox3.Controls.Add(this.tb_ProductQuantity_i);
			this.groupBox3.Location = new System.Drawing.Point(12, 204);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(320, 124);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 16);
			this.label14.TabIndex = 6;
			this.label14.Text = "Add Product";
			// 
			// Check_neverExist
			// 
			this.Check_neverExist.AutoSize = true;
			this.Check_neverExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_neverExist.Location = new System.Drawing.Point(8, 15);
			this.Check_neverExist.Name = "Check_neverExist";
			this.Check_neverExist.Size = new System.Drawing.Size(78, 20);
			this.Check_neverExist.TabIndex = 5;
			this.Check_neverExist.Text = "Add new";
			this.Check_neverExist.UseVisualStyleBackColor = true;
			this.Check_neverExist.CheckedChanged += new System.EventHandler(this.Check_neverExist_CheckedChanged);
			// 
			// tb_addProduct_i
			// 
			this.tb_addProduct_i.Location = new System.Drawing.Point(89, 15);
			this.tb_addProduct_i.Name = "tb_addProduct_i";
			this.tb_addProduct_i.Size = new System.Drawing.Size(225, 20);
			this.tb_addProduct_i.TabIndex = 2;
			this.tb_addProduct_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Anew_kp);
			// 
			// tb_ProductID_i
			// 
			this.tb_ProductID_i.Location = new System.Drawing.Point(89, 42);
			this.tb_ProductID_i.Name = "tb_ProductID_i";
			this.tb_ProductID_i.Size = new System.Drawing.Size(111, 20);
			this.tb_ProductID_i.TabIndex = 4;
			this.tb_ProductID_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PID_KP);
			// 
			// cb_selectGood_i
			// 
			this.cb_selectGood_i.FormattingEnabled = true;
			this.cb_selectGood_i.Location = new System.Drawing.Point(92, 15);
			this.cb_selectGood_i.Name = "cb_selectGood_i";
			this.cb_selectGood_i.Size = new System.Drawing.Size(188, 21);
			this.cb_selectGood_i.TabIndex = 0;
			this.cb_selectGood_i.SelectedIndexChanged += new System.EventHandler(this.cb_selectGood_i_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 43);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 16);
			this.label11.TabIndex = 1;
			this.label11.Text = "Product ID";
			// 
			// tb_ProductQuantity_i
			// 
			this.tb_ProductQuantity_i.Location = new System.Drawing.Point(267, 42);
			this.tb_ProductQuantity_i.Name = "tb_ProductQuantity_i";
			this.tb_ProductQuantity_i.Size = new System.Drawing.Size(47, 20);
			this.tb_ProductQuantity_i.TabIndex = 3;
			this.tb_ProductQuantity_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quan_KP);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(206, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "Quantity";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox4.Controls.Add(this.tb_Quant_i_old);
			this.groupBox4.Controls.Add(this.tb_Price_i_old);
			this.groupBox4.Controls.Add(this.cb_color_i);
			this.groupBox4.Controls.Add(this.cb_memo_i);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.cb_selectGood_i);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Location = new System.Drawing.Point(338, 204);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(286, 124);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			// 
			// tb_Price_i
			// 
			this.tb_Price_i.Location = new System.Drawing.Point(89, 91);
			this.tb_Price_i.Name = "tb_Price_i";
			this.tb_Price_i.Size = new System.Drawing.Size(225, 20);
			this.tb_Price_i.TabIndex = 10;
			this.tb_Price_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KP);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 92);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 16);
			this.label13.TabIndex = 9;
			this.label13.Text = "Price";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(236, 334);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(197, 39);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tb_ProductColor
			// 
			this.tb_ProductColor.Location = new System.Drawing.Point(89, 68);
			this.tb_ProductColor.Name = "tb_ProductColor";
			this.tb_ProductColor.Size = new System.Drawing.Size(90, 20);
			this.tb_ProductColor.TabIndex = 7;
			this.tb_ProductColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Col_KP);
			// 
			// tdks
			// 
			this.tdks.AutoSize = true;
			this.tdks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tdks.Location = new System.Drawing.Point(6, 69);
			this.tdks.Name = "tdks";
			this.tdks.Size = new System.Drawing.Size(39, 16);
			this.tdks.TabIndex = 6;
			this.tdks.Text = "Color";
			// 
			// tb_ProductMemo
			// 
			this.tb_ProductMemo.Location = new System.Drawing.Point(247, 68);
			this.tb_ProductMemo.Name = "tb_ProductMemo";
			this.tb_ProductMemo.Size = new System.Drawing.Size(67, 20);
			this.tb_ProductMemo.TabIndex = 5;
			this.tb_ProductMemo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Memo_KP);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(185, 69);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 2;
			this.label12.Text = "Memory";
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.Location = new System.Drawing.Point(12, 600);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(97, 57);
			this.btn_delete.TabIndex = 8;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseMnemonic = false;
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 531);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(612, 63);
			this.dataGridView1.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(7, 68);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(38, 16);
			this.label15.TabIndex = 15;
			this.label15.Text = "Price";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(148, 43);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 16);
			this.label16.TabIndex = 13;
			this.label16.Text = "Memory";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(162, 69);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(55, 16);
			this.label17.TabIndex = 11;
			this.label17.Text = "Quantity";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 43);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(39, 16);
			this.label18.TabIndex = 14;
			this.label18.Text = "Color";
			// 
			// cb_memo_i
			// 
			this.cb_memo_i.FormattingEnabled = true;
			this.cb_memo_i.Location = new System.Drawing.Point(210, 41);
			this.cb_memo_i.Name = "cb_memo_i";
			this.cb_memo_i.Size = new System.Drawing.Size(70, 21);
			this.cb_memo_i.TabIndex = 17;
			this.cb_memo_i.SelectedIndexChanged += new System.EventHandler(this.cb_memo_i_SelectedIndexChanged);
			// 
			// cb_color_i
			// 
			this.cb_color_i.FormattingEnabled = true;
			this.cb_color_i.Location = new System.Drawing.Point(51, 41);
			this.cb_color_i.Name = "cb_color_i";
			this.cb_color_i.Size = new System.Drawing.Size(91, 21);
			this.cb_color_i.TabIndex = 18;
			this.cb_color_i.SelectedIndexChanged += new System.EventHandler(this.cb_color_i_SelectedIndexChanged);
			// 
			// tb_Price_i_old
			// 
			this.tb_Price_i_old.Location = new System.Drawing.Point(51, 67);
			this.tb_Price_i_old.Name = "tb_Price_i_old";
			this.tb_Price_i_old.Size = new System.Drawing.Size(105, 20);
			this.tb_Price_i_old.TabIndex = 19;
			// 
			// tb_Quant_i_old
			// 
			this.tb_Quant_i_old.Location = new System.Drawing.Point(223, 68);
			this.tb_Quant_i_old.Name = "tb_Quant_i_old";
			this.tb_Quant_i_old.Size = new System.Drawing.Size(57, 20);
			this.tb_Quant_i_old.TabIndex = 20;
			this.tb_Quant_i_old.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quant_i_old_KP);
			// 
			// frmGoodReceived
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 668);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.DGV_Receipt_i);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmGoodReceived";
			this.Text = "frmGoodReceiver";
			this.Load += new System.EventHandler(this.frmGoodReceived_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_i)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.TextBox TB_AccordingToReceiptNo_i;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TB_ReceiptNo_i;
		private System.Windows.Forms.DataGridView DGV_Receipt_i;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox Check_neverExist;
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
		private System.Windows.Forms.TextBox tb_Price_i;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox TB_ReceiverName_i;
		private System.Windows.Forms.CheckBox checkIfNew;
		private System.Windows.Forms.ComboBox cb_receiver_i;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tb_Quant_i_old;
		private System.Windows.Forms.TextBox tb_Price_i_old;
		private System.Windows.Forms.ComboBox cb_color_i;
		private System.Windows.Forms.ComboBox cb_memo_i;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
	}
}