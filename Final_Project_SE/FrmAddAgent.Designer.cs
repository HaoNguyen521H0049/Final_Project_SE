namespace Final_Project_SE
{
	partial class FrmAddAgent
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbUn = new System.Windows.Forms.TextBox();
			this.tbPw = new System.Windows.Forms.TextBox();
			this.tbE = new System.Windows.Forms.TextBox();
			this.tbLn = new System.Windows.Forms.TextBox();
			this.tbFn = new System.Windows.Forms.TextBox();
			this.cbR = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbFn);
			this.groupBox1.Controls.Add(this.cbR);
			this.groupBox1.Controls.Add(this.tbLn);
			this.groupBox1.Controls.Add(this.tbE);
			this.groupBox1.Controls.Add(this.tbPw);
			this.groupBox1.Controls.Add(this.tbUn);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 168);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(265, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Role";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(143, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(222, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Add new account";
			// 
			// tbUn
			// 
			this.tbUn.Location = new System.Drawing.Point(87, 52);
			this.tbUn.Name = "tbUn";
			this.tbUn.Size = new System.Drawing.Size(146, 20);
			this.tbUn.TabIndex = 4;
			this.tbUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.un_kp);
			// 
			// tbPw
			// 
			this.tbPw.Location = new System.Drawing.Point(87, 82);
			this.tbPw.Name = "tbPw";
			this.tbPw.Size = new System.Drawing.Size(146, 20);
			this.tbPw.TabIndex = 5;
			// 
			// tbE
			// 
			this.tbE.Location = new System.Drawing.Point(309, 82);
			this.tbE.Name = "tbE";
			this.tbE.Size = new System.Drawing.Size(145, 20);
			this.tbE.TabIndex = 6;
			// 
			// tbLn
			// 
			this.tbLn.Location = new System.Drawing.Point(309, 113);
			this.tbLn.Name = "tbLn";
			this.tbLn.Size = new System.Drawing.Size(145, 20);
			this.tbLn.TabIndex = 7;
			// 
			// tbFn
			// 
			this.tbFn.Location = new System.Drawing.Point(87, 113);
			this.tbFn.Name = "tbFn";
			this.tbFn.Size = new System.Drawing.Size(146, 20);
			this.tbFn.TabIndex = 1;
			// 
			// cbR
			// 
			this.cbR.FormattingEnabled = true;
			this.cbR.Location = new System.Drawing.Point(309, 51);
			this.cbR.Name = "cbR";
			this.cbR.Size = new System.Drawing.Size(145, 21);
			this.cbR.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(262, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(250, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Lastname";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 116);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Firstname";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(99, 186);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 57);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.LightCoral;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(369, 186);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(97, 57);
			this.btnExit.TabIndex = 17;
			this.btnExit.Text = "Cancel";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmAddAgent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 250);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmAddAgent";
			this.Text = "frmAddAgent";
			this.Load += new System.EventHandler(this.frmAddAgent_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbFn;
		private System.Windows.Forms.ComboBox cbR;
		private System.Windows.Forms.TextBox tbLn;
		private System.Windows.Forms.TextBox tbE;
		private System.Windows.Forms.TextBox tbPw;
		private System.Windows.Forms.TextBox tbUn;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExit;
	}
}