namespace Final_Project_SE
{
	partial class DB_Select
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_browseDB = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select database";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Buu Database";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hao Database";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Snow;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button1.Location = new System.Drawing.Point(130, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "Select";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Snow;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button2.Location = new System.Drawing.Point(130, 114);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(177, 39);
			this.button2.TabIndex = 4;
			this.button2.Text = "Select";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.LightCoral;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.btnExit.Location = new System.Drawing.Point(7, 292);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(300, 38);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnConfirm);
			this.groupBox1.Controls.Add(this.tb_browseDB);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(12, 159);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 127);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Browse DB";
			// 
			// tb_browseDB
			// 
			this.tb_browseDB.Location = new System.Drawing.Point(6, 39);
			this.tb_browseDB.Name = "tb_browseDB";
			this.tb_browseDB.Size = new System.Drawing.Size(283, 20);
			this.tb_browseDB.TabIndex = 9;
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.btnConfirm.Location = new System.Drawing.Point(6, 65);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(283, 38);
			this.btnConfirm.TabIndex = 9;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// DB_Select
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(324, 338);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "DB_Select";
			this.Text = "DB_Select";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.TextBox tb_browseDB;
		private System.Windows.Forms.Label label5;
	}
}